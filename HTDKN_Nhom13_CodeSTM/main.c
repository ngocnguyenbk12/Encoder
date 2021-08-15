#include "stm32f4xx.h"
#include "system_timetick.h"
#include "math.h"
void init_UART(void);
void init_PWM(void);
void init_ENCODER(void);
void init_TgEncoder(void);
void BytestoArray(uint8_t *a);
void UART4_IRQHandler(void);
float ArrayToFloat(uint8_t b[5]);
void pid_pos(void);
void pid_speed(void);

uint8_t chieu=1;
uint8_t g=0;
uint8_t mode=0;
uint8_t mode_cu=0;
float goc=0;

uint8_t data[5];
uint32_t data32=0;
float dataf;
int i=0;
uint16_t l=0;
int x=0;


float Ki;
float Kd;
float Kp;
float Setpoint;
float ek2=0;
float ek1=0;
float ek;
float uk1=0;
float uk;

uint8_t txbuff[5];
uint8_t 	rxbuff[5];


float count=0,count_temp=0, count_recent=0,count_update=0;
float motor_speed;


int main(void)
{
	
	init_UART();
	while(mode==0){;}	
	init_PWM();
	init_ENCODER();
	init_TgEncoder();			

	while(1)
	{		

	}	
}


void init_UART(void)
{
	/*********************chan UART******************************/
	GPIO_InitTypeDef 	GPIO_InitStructure; 

	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA, ENABLE); // Clock
	
	// Chuc nang
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource0, GPIO_AF_UART4);
  GPIO_PinAFConfig(GPIOA, GPIO_PinSource1, GPIO_AF_UART4);
	// Config Tx PA0 
	GPIO_InitStructure.GPIO_Pin   = GPIO_Pin_0;
  GPIO_InitStructure.GPIO_Mode  = GPIO_Mode_AF;
  GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
  GPIO_InitStructure.GPIO_PuPd  = GPIO_PuPd_UP;
  GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
  GPIO_Init(GPIOA, &GPIO_InitStructure);	
	// Config Rx PA1
	GPIO_InitStructure.GPIO_Pin   = GPIO_Pin_1;
  GPIO_InitStructure.GPIO_Mode  = GPIO_Mode_AF;
  GPIO_Init(GPIOA, &GPIO_InitStructure); 
	/*********************UART******************************/
	USART_InitTypeDef USART_InitStructure;  
	
	
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_UART4, ENABLE);
	
	//UART config
	USART_InitStructure.USART_BaudRate = 115200;
  USART_InitStructure.USART_WordLength = USART_WordLength_8b;
  USART_InitStructure.USART_StopBits = USART_StopBits_1;
  USART_InitStructure.USART_Parity = USART_Parity_No;
  USART_InitStructure.USART_HardwareFlowControl = USART_HardwareFlowControl_None;
  USART_InitStructure.USART_Mode = USART_Mode_Rx | USART_Mode_Tx;
  USART_Init(UART4, &USART_InitStructure);
  /* Enable USART */
  USART_Cmd(UART4, ENABLE);
	
	/*********************DMA+Ngat**************************/
	DMA_InitTypeDef  	DMA_InitStructure;
	NVIC_InitTypeDef NVIC_InitStructure;
	
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_DMA1, ENABLE);
	
	USART_DMACmd(UART4, USART_DMAReq_Tx, ENABLE);
	USART_DMACmd(UART4, USART_DMAReq_Rx, ENABLE);	
	
	//Tx
	DMA_InitStructure.DMA_Channel = DMA_Channel_4;  
  DMA_InitStructure.DMA_PeripheralBaseAddr = (uint32_t)&UART4->DR;
  DMA_InitStructure.DMA_Memory0BaseAddr = (uint32_t)txbuff;
  DMA_InitStructure.DMA_DIR = DMA_DIR_MemoryToPeripheral;
  DMA_InitStructure.DMA_BufferSize = 4;
  DMA_InitStructure.DMA_PeripheralInc = DMA_PeripheralInc_Disable;
  DMA_InitStructure.DMA_MemoryInc = DMA_MemoryInc_Enable;
  DMA_InitStructure.DMA_PeripheralDataSize = DMA_PeripheralDataSize_Byte;
  DMA_InitStructure.DMA_MemoryDataSize = DMA_MemoryDataSize_Byte;
  DMA_InitStructure.DMA_Mode = DMA_Mode_Normal;
  DMA_InitStructure.DMA_Priority = DMA_Priority_High;
  DMA_InitStructure.DMA_FIFOMode = DMA_FIFOMode_Disable;         
  DMA_InitStructure.DMA_FIFOThreshold = DMA_FIFOThreshold_HalfFull;
  DMA_InitStructure.DMA_MemoryBurst = DMA_MemoryBurst_Single;
  DMA_InitStructure.DMA_PeripheralBurst = DMA_PeripheralBurst_Single;
  DMA_Init(DMA1_Stream4, &DMA_InitStructure);
  DMA_Cmd(DMA1_Stream4, ENABLE);
	
	//Rx
	DMA_InitStructure.DMA_Channel = DMA_Channel_4;  
  DMA_InitStructure.DMA_PeripheralBaseAddr = (uint32_t)&UART4->DR;
  DMA_InitStructure.DMA_Memory0BaseAddr = (uint32_t)rxbuff;
  DMA_InitStructure.DMA_DIR = DMA_DIR_PeripheralToMemory;
  DMA_InitStructure.DMA_BufferSize = 5;
  DMA_InitStructure.DMA_PeripheralInc = DMA_PeripheralInc_Disable;
  DMA_InitStructure.DMA_MemoryInc = DMA_MemoryInc_Enable;
  DMA_InitStructure.DMA_PeripheralDataSize = DMA_PeripheralDataSize_Byte;
  DMA_InitStructure.DMA_MemoryDataSize = DMA_MemoryDataSize_Byte;
  DMA_InitStructure.DMA_Mode = DMA_Mode_Normal;//DMA_Mode_Circular;
  DMA_InitStructure.DMA_Priority = DMA_Priority_High;
  DMA_InitStructure.DMA_FIFOMode = DMA_FIFOMode_Disable;         
  DMA_InitStructure.DMA_FIFOThreshold = DMA_FIFOThreshold_HalfFull;
  DMA_InitStructure.DMA_MemoryBurst = DMA_MemoryBurst_Single;
  DMA_InitStructure.DMA_PeripheralBurst = DMA_PeripheralBurst_Single;
  DMA_Init(DMA1_Stream2, &DMA_InitStructure);
  DMA_Cmd(DMA1_Stream2, ENABLE);
	
	NVIC_InitStructure.NVIC_IRQChannel = DMA1_Stream2_IRQn;
  NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority = 0;
  NVIC_InitStructure.NVIC_IRQChannelSubPriority = 0;
  NVIC_InitStructure.NVIC_IRQChannelCmd = ENABLE;
  NVIC_Init(&NVIC_InitStructure);  
	
	DMA_ITConfig(DMA1_Stream2, DMA_IT_TC, ENABLE);
}	

void DMA1_Stream2_IRQHandler(void)
{	
		DMA_ClearITPendingBit(DMA1_Stream2, DMA_IT_TCIF2);
		for(i=0; i<5; i++)
    data[i] = rxbuff[i];

		if(data[0]=='P')
			{Kp=ArrayToFloat(data);

			}
		if(data[0]=='I')
			{Ki=ArrayToFloat(data);}
		if(data[0]=='D')
			{Kd=ArrayToFloat(data);}
		if(data[0]=='A')
			{Setpoint=ArrayToFloat(data);
			mode=1;g=0;
				if(mode_cu==2)
				{
				uk1=0;
				ek1=0;
				ek2=0;}
				mode_cu=mode;
			}
		if(data[0]=='B')
			{Setpoint=ArrayToFloat(data);
			mode=2;
				if(mode_cu==1)
				{
				uk1=0;
				ek1=0;
				ek2=0;}
				mode_cu=mode;
			}

	DMA_Cmd(DMA1_Stream2, ENABLE);
	
}

void init_ENCODER(void)
{	
	/******************2 chan PA6-PA7****************/
		GPIO_InitTypeDef 	GPIO_InitStructure; 
  // Clock
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA, ENABLE);
	// 2 chan encoder PA6-PA7
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource6, GPIO_AF_TIM3);
  GPIO_PinAFConfig(GPIOA, GPIO_PinSource7, GPIO_AF_TIM3);	
	//Chuc nang encoder
	GPIO_InitStructure.GPIO_Pin = GPIO_Pin_6| GPIO_Pin_7 ;
	GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF;
	GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
	GPIO_InitStructure.GPIO_PuPd = GPIO_PuPd_NOPULL;
	GPIO_InitStructure.GPIO_Speed = GPIO_Speed_50MHz;
	GPIO_Init(GPIOA, &GPIO_InitStructure);

	/*********************Timer*********************/
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	TIM_ICInitTypeDef TIM_BaseStructic;
	//Encoder
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM3, ENABLE); // Doc encoder
	

	TIM_BaseStruct.TIM_Prescaler=0;
	TIM_BaseStruct.TIM_Period=0xFFFF;
	TIM_BaseStruct.TIM_ClockDivision=0;
	TIM_TimeBaseInit(TIM3, &TIM_BaseStruct);	

  /*TIM_BaseStructic.TIM_Channel=TIM_Channel_1 | TIM_Channel_2;
	TIM_BaseStructic.TIM_ICPolarity=TIM_ICPolarity_BothEdge;
	TIM_BaseStructic.TIM_ICFilter=15;
	TIM_BaseStructic.TIM_ICSelection=TIM_ICSelection_DirectTI;
	TIM_ICInit(TIM3, &TIM_BaseStruct);*/

	TIM_EncoderInterfaceConfig(TIM3, TIM_EncoderMode_TI12, TIM_ICPolarity_Rising, TIM_ICPolarity_Rising);
	TIM_SetCounter(TIM3, 0);
	TIM_Cmd(TIM3,ENABLE);
	TIM_ClearFlag(TIM3,TIM_FLAG_Update);
	TIM_ITConfig(TIM3, TIM_IT_Update, ENABLE);

	/*************************Ngat Encoder******************/
	NVIC_PriorityGroupConfig(NVIC_PriorityGroup_2);
	
	NVIC_InitTypeDef NVIC_InitStructure;
	//Encoder
	NVIC_InitStructure.NVIC_IRQChannel = TIM3_IRQn;
	NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority=2;
	NVIC_InitStructure.NVIC_IRQChannelSubPriority=0;
	NVIC_InitStructure.NVIC_IRQChannelCmd = ENABLE ;
	NVIC_Init(&NVIC_InitStructure);

}

void init_TgEncoder(void)
{	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
		//Thoi gian Encoder
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM2, ENABLE); // Tgian encoder	
	
	TIM_BaseStruct.TIM_Period = 57; // delay 5ms          
	TIM_BaseStruct.TIM_Prescaler = (7200 - 1);	 //1khz
	TIM_BaseStruct.TIM_ClockDivision = 0x0;    
	TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;  
	TIM_TimeBaseInit(TIM2, &TIM_BaseStruct);	
	
	TIM_ClearFlag(TIM2, TIM_FLAG_Update);
	TIM_Cmd(TIM2, ENABLE);	
	TIM_ITConfig(TIM2, TIM_IT_Update, ENABLE);	
	//Thoi_gian_encoder
		NVIC_InitTypeDef NVIC_InitStructure;
	NVIC_PriorityGroupConfig(NVIC_PriorityGroup_2);
	NVIC_InitStructure.NVIC_IRQChannel = TIM2_IRQn;
  NVIC_InitStructure.NVIC_IRQChannelPreemptionPriority = 1;
  NVIC_InitStructure.NVIC_IRQChannelSubPriority = 0;
  NVIC_InitStructure.NVIC_IRQChannelCmd = ENABLE;
  NVIC_Init(&NVIC_InitStructure);
}

void init_PWM(void)
{		/*********************chan PWM******************************/
	
	GPIO_InitTypeDef 	GPIO_InitStructure; 
	//CW PD12
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOD, ENABLE);
	
	GPIO_PinAFConfig(GPIOD, GPIO_PinSource12, GPIO_AF_TIM4);

  GPIO_InitStructure.GPIO_Pin = GPIO_Pin_12;
  GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
  GPIO_InitStructure.GPIO_PuPd = GPIO_PuPd_NOPULL;
  GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF;
  GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;
  GPIO_Init(GPIOD, &GPIO_InitStructure);	
	//CCW PA2
	RCC_AHB1PeriphClockCmd(RCC_AHB1Periph_GPIOA, ENABLE);
	
	GPIO_PinAFConfig(GPIOA, GPIO_PinSource2, GPIO_AF_TIM9);

  GPIO_InitStructure.GPIO_Pin = GPIO_Pin_2;
  GPIO_InitStructure.GPIO_OType = GPIO_OType_PP;
  GPIO_InitStructure.GPIO_PuPd = GPIO_PuPd_NOPULL;
  GPIO_InitStructure.GPIO_Mode = GPIO_Mode_AF;
  GPIO_InitStructure.GPIO_Speed = GPIO_Speed_100MHz;
  GPIO_Init(GPIOA, &GPIO_InitStructure);	
	/*********************timer PWM******************************/
	
	TIM_TimeBaseInitTypeDef TIM_BaseStruct;
	//CW PD12
	RCC_APB1PeriphClockCmd(RCC_APB1Periph_TIM4, ENABLE);
	
  TIM_BaseStruct.TIM_Prescaler =64; //5-10khz, 64-1k, 1310-50Hz,0-65kHz
  TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;	
	                                                                                            
  TIM_BaseStruct.TIM_Period = 1280;
  TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
  TIM_BaseStruct.TIM_RepetitionCounter = 0;
	
  TIM_TimeBaseInit(TIM4, &TIM_BaseStruct);     //Initialize TIM4 
  TIM_Cmd(TIM4, ENABLE);	    //Start count on TIM4 
		
	//CCW PA2
	RCC_APB2PeriphClockCmd(RCC_APB2Periph_TIM9, ENABLE);
	
  TIM_BaseStruct.TIM_Prescaler = 130; //11-10kHz, 2621-50Hz,1-65kHz
  TIM_BaseStruct.TIM_CounterMode = TIM_CounterMode_Up;	
	
  TIM_BaseStruct.TIM_Period = 1280;
  TIM_BaseStruct.TIM_ClockDivision = TIM_CKD_DIV1;
  TIM_BaseStruct.TIM_RepetitionCounter = 0;
	
  TIM_TimeBaseInit(TIM9, &TIM_BaseStruct);     //Initialize TIM5 
  TIM_Cmd(TIM9, ENABLE);	    //Start count on TIM5
		/*********************PWM******************************/	
  TIM_OCInitTypeDef TIM_OCStruct;
	//CW PD12
    /* PWM mode 2 = Clear on compare match */
    /* PWM mode 1 = Set on compare match */
	TIM_OCStruct.TIM_OCMode = TIM_OCMode_PWM2;
  TIM_OCStruct.TIM_OutputState = TIM_OutputState_Enable;
  TIM_OCStruct.TIM_OCPolarity = TIM_OCPolarity_Low;
	
	TIM_OCStruct.TIM_Pulse = 0; // % duty cycle
  TIM_OC1Init(TIM4, &TIM_OCStruct);
  TIM_OC1PreloadConfig(TIM4, TIM_OCPreload_Enable);
	
	//CCW PA2
    /* PWM mode 2 = Clear on compare match */
    /* PWM mode 1 = Set on compare match */
	TIM_OCStruct.TIM_OCMode = TIM_OCMode_PWM2;
  TIM_OCStruct.TIM_OutputState = TIM_OutputState_Enable;
  TIM_OCStruct.TIM_OCPolarity = TIM_OCPolarity_Low;
	
	TIM_OCStruct.TIM_Pulse = 0; // % duty cycle
  TIM_OC1Init(TIM9, &TIM_OCStruct);
  TIM_OC1PreloadConfig(TIM9, TIM_OCPreload_Enable);
	
	
}


float ArrayToFloat(uint8_t b[5])
{float data1;
uint32_t u = b[1] | (b[2] << 8) | (b[3] << 16) | (b[4] << 24);
memcpy(&data1,&u,sizeof(u));
return data1;
}

void BytestoArray(uint8_t *a)
{	
	int k;
	for(k=0;k<4;k++)
	{
		txbuff[k]=a[k];
	}
}

void TIM3_IRQHandler(void)
{
	uint16_t timer_temp;
	if (TIM_GetFlagStatus(TIM3, TIM_FLAG_Update)==SET)
	{
		TIM_ClearFlag(TIM3, TIM_FLAG_Update);
		timer_temp = TIM_GetCounter(TIM3);
		if(mode==2)
		{
		if (timer_temp == 65535) count_temp=0	;
	  if (timer_temp == 0)			count_temp=1;
		}
		
		else
		{
		if (timer_temp == 65535) count_temp--	;
	  if (timer_temp == 0)			count_temp++;
		}
	}
}
void  TIM2_IRQHandler(void)
{
	if (TIM_GetFlagStatus(TIM2, TIM_FLAG_Update)==SET)
			{
				TIM_ClearFlag(TIM2, TIM_FLAG_Update);

	if(mode==1)
				{
				count=TIM_GetCounter(TIM3)+65535*count_temp;
				goc=count*360/1320;

				if(x==20)
				{x=0;

				BytestoArray(&goc);

			DMA_ClearFlag(DMA1_Stream4, DMA_FLAG_TCIF4);
			DMA1_Stream4->NDTR = 4;
			DMA_Cmd(DMA1_Stream4, ENABLE);

				}	
				else 
					x++;
					pid_pos();}
 else if (mode==2)
	{
		pid_speed();
		if(l==5)
		{		l=0;
					count_update=count_recent;
					count_recent=TIM_GetCounter(TIM3)+65536*count_temp;
					
					motor_speed = (float)(count_recent - count_update)*2400/1320;  //ngat 25ms , encoder 1320 xung

		count_recent=TIM_GetCounter(TIM3);
			count_temp=0;		

				if(x==4)
				{x=0;
				BytestoArray(&motor_speed);

			DMA_ClearFlag(DMA1_Stream4, DMA_FLAG_TCIF4);
			DMA1_Stream4->NDTR = 4;
			DMA_Cmd(DMA1_Stream4, ENABLE);

				}	
				else 
					x++;

		}
		else l++;
	}
			}
}

void pid_pos(void)
{
if(((fabs(Setpoint*1320/360-count)>fabs(Setpoint*0.05))&(Setpoint!=0))|((fabs(count)>10)&(Setpoint==0)))
{

		ek=Setpoint*1320/360-count;


		uk=uk1+Kp*(ek-ek1)+Ki*(0.0025)*(ek+ek1)+Kd*(ek-2*ek1+ek2)*200;
		ek2=ek1;
		ek1=ek; 
		uk1=uk;
		uk=uk;
		if(uk>1){uk=1;}
		else if (uk<-1){uk=-1;};
		if(uk>0)
			chieu=1;
		else
			chieu=0;
}
else 
uk=0;

		
if(chieu==1)
{
TIM_SetCompare1(TIM4,uk*1280);
TIM_SetCompare1(TIM9,0);
}
else 
{
	uk=-uk;
TIM_SetCompare1(TIM9,uk*1280);TIM_SetCompare1(TIM4,0);}
}	


void pid_speed(void)
{

ek=Setpoint-motor_speed;

uk=uk1+Kp*(ek-ek1)+Ki*(0.0125)*(ek+ek1)+Kd*(ek-2*ek1+ek2)*40;
ek2=ek1;
ek1=ek; 
uk1=uk;
uk=uk;
if(uk>1){uk=1;}
else if (uk<0){uk=0;};

TIM_SetCompare1(TIM4,uk*1280);
}



	