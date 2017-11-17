#define LED 13
#define TOP 2
#define BOTTOM 3
#define LEFT 4
#define RIGHT 5

int left = 0, right = 0, top = 0, bottom = 0;
int reset = 0;

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(TOP, INPUT);
  pinMode(BOTTOM, INPUT);
  pinMode(LEFT, INPUT);
  pinMode(RIGHT, INPUT);
}

void loop() {
  left = digitalRead(IN);
  Serial.flush();
  if(val == 0 || reset == 1) {
    Serial.println(val);
    reset = (val == 0 ? 1 : 0);
  }
  delay(30);
}
