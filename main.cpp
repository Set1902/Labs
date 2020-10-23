#include <iostream>
using namespace std;
int get_dec(int* a,int num);
int fact (int a);
int count(int* a, int* b);
void get_bool(int dec, int size, int* address);
void print_bool(int* msg, int size);
int errorlevel(int* msg, int size);
int main ()
{
	std::cout <<"\n"<<"\n"<<"Homework by Abrosimov E. IU5-62\n"<<"\n";
	std::cout <<"Sending 1010\n"<<"\n"<<"\n";
    int origin_word[4]={1,0,1,0};
	int dec_origin_word;
	int moved_word[7]={1,0,1,0,0,0,0};
	int dec_moved_word;
	int code_word[4]={1,0,1,1};
	int dec_code_word;
	int rest;
	int message[7]={0,0,0,0,0,0,0};
	int dec_message;
	int rcvd_message[7]={0,0,0,0,0,0,0};
	int dec_rcvd_message;
	int error[7]={0,0,0,0,0,0,0};
	int dec_error;
	int new_rest;
	int digit;
	int number_of_errors_captured[7]={0,0,0,0,0,0,0};
	int number_of_errors[7]={0,0,0,0,0,0,0};
	dec_origin_word=get_dec(origin_word, 4);
	dec_moved_word=get_dec(moved_word, 7);
	dec_code_word=get_dec(code_word, 4);
	rest=dec_moved_word%dec_code_word;
	dec_message=dec_moved_word+rest;
	get_bool(dec_message,7,message);
	std::cout<<"=========================================\n"<<
	"|| Encoded message to be sent: ";
	print_bool(message,7);
	std::cout<<" ||\n"<<"=========================================\n";
	getchar();
	//DECODING
	for (dec_error=1; dec_error<=127; dec_error++)
	{
		get_bool(dec_error, 7, error);
//		std::cout<<"Random error: ";
//		print_bool(error, 7);
		digit=errorlevel(error, 7);
//		std::cout<<"\n"<<"errorlevel:"<<digit<<"\n";		
		dec_rcvd_message=dec_message;
		get_bool(dec_rcvd_message, 7, rcvd_message);
		for (int counter=0; counter<7; counter++)
		{
		if ((error[counter]==1)&&(rcvd_message[counter]==1)) 
			rcvd_message[counter]=0;
		else 
		{
			if ((error[counter]==1)&&(rcvd_message[counter]==0))
			rcvd_message[counter]=1;
		}
		}
		dec_rcvd_message=get_dec(rcvd_message, 7);
//		std::cout<<"Dec_message:"<<dec_rcvd_message<<"\n";
//		std::cout<<"\n"<<"Message received:";
//		print_bool(rcvd_message, 7);
//		std::cout<<"\n";
	    new_rest=dec_error%dec_code_word;
//		std::cout<<"OSTATOK: "<<new_rest<<"\n";
		get_dec(rcvd_message,7);
		if (new_rest==0) number_of_errors_captured[digit-1]++;
		number_of_errors[digit-1]++;
//	    std::cout<<"\n"<<"errors occured: "<<number_of_errors[digit-1];
//	    std::cout<<"\n"<<"errors chased through: "<<number_of_errors_captured[digit-1];									 
//		std::cout<<"\n"<<"\n"<<"\n";
//		getchar();
	}
	std::cout<<"Total table:"<<"\n"<<"\n";
	for (int k=0; k<7; k++)
	{
		std::cout<<"errorlevel="<<k+1<<". errors sent:"<<number_of_errors[k]<<". errors detected:"<<number_of_errors[k]-number_of_errors_captured[k]<<"\n";
    }
	std::cout<<"\n";
	for (int i=0; i<7; i++)
	{
		cout<<"errorlevel="<<i+1<<"   C0=";
		double temp=(double)fact(i+1)*fact(7-i-1)*(number_of_errors[i]-number_of_errors_captured[i])/fact(7);
		cout<<temp<<"\n";
	}
	return 0;	
}
int fact(int a)
{
	int b=1;
	for (int i=1; i<=a; i++)
		b*=i;
	return b;
}		
void print_bool(int* msg, int size)
{ 
	for(int i=0; i<size; i++)
	std::cout<<*(msg+i);
}
int errorlevel(int* msg, int size)
{
	int k=0;
	for(int i=0; i<size; i++)
	{
		if (*(msg+i)==1) k++;
	}
	return k;
}
void get_bool(int dec, int size, int* address)
{
	int i=1;
	int k=0;
	for(k=0; k<size-1; k++)
	{
		i*=2;
	}
	for(i; i>=1; i=i/2)
	{
		if (dec>=i)
		{
			dec=dec-i;
			*address=1;
		}
		else 
		{
			*address=0;
		}
	address++;
	}
}
int count (int* a, int* b)
{
	for (int i=0; i<4; i++)
	{
		if (*(a+i)!=*(b+i)) return 1;
	}
	return 0;
}
int get_dec(int* a, int num)
{
	int dec_number=0;
	int i=0;
	int curr_bool=0;
	while(i<num)
	{
		curr_bool=*(a+i);
		for(int k=0;k<(num-i-1);k++)
			curr_bool*=2;
		dec_number+=curr_bool;
		i++;
	}
	return dec_number;
}
