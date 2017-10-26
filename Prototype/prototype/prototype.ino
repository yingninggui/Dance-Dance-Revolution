#define LED 13
#define IN 2

int val = 0;

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(IN, INPUT);
}

void loop() {
  val = digitalRead(IN);
  Serial.flush();
  if(val == 0)
    Serial.println(val);
  delay(30);
}
