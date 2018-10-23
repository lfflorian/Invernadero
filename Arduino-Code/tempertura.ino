
#include <DHT.h>

int temperatura, humedad, luminosidad;
const int pinVentilador=3;
const int pinRele= 4;
const int LDRPin = A0; //sensor de luz
const int sensorDHT=A2;
const int threshold = 200;

int period = 2000;
unsigned long time_now = 0;

int valorLDR=0;

DHT dht (sensorDHT,DHT11);

void setup(){
    Serial.begin(9600); //Iniciamos comunicaciòn con la PC a 9600 Batios
    pinMode(pinVentilador,OUTPUT); //Le indicamos que el ventilador (pin 8) serà de salida
    pinMode(pinRele , OUTPUT);  //definir pin como salida
    pinMode(LDRPin, INPUT);
    dht.begin(); //Iniciamos nuestro sensor DHT11
 }

void loop(){
      if(millis() > time_now + period){
          time_now = millis();
          ObtenerDatos();
          Ventilador(temperatura);
          Luz(luminosidad);
          EnviarDatos();
      }
  } 

 void ObtenerDatos() {
    humedad= dht.readHumidity(); //Funcion incluida en la libreria. Permite leer la humedad.
    temperatura= dht.readTemperature(); //Permite leer la temperatura.
    luminosidad= analogRead(LDRPin); // Lectura del sensor de iluminosidad
 }

 void EnviarDatos() {
    Serial.print("Temperatura: ");
    Serial.print(temperatura);
    Serial.println("C"); //Tempertura: 29ºC
    delay(500);
    Serial.print("Luminosidad: ");
    Serial.print(luminosidad);
    Serial.println("In"); //Luminosidad: 112In
 }
 
 void Ventilador(int valor){
    if (valor>=19){ //Condición para mantener el ambiente fresco.
        digitalWrite(pinVentilador,HIGH); //Encendemos el ventilador
    } else 
    {
        digitalWrite(pinVentilador,LOW); 
    }
 }

 void Luz(int valor) {
    if (valor < threshold)
    {
        digitalWrite(pinRele, HIGH);
    } else 
    {
        digitalWrite(pinRele, LOW);
    }
 }


  void MotorAgua(int valor) {
    // if (valor >= numero)
  }
