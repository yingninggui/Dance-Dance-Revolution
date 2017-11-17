#define UP 2
#define DOWN 3
#define LEFT 4
#define RIGHT 5
#define CONSTANT 4

int left = 0, right = 0, up = 0, down = 0, _left = -1, _right = -1, _up = -1, _down = -1;
int reset = 0;

void setup() {
  Serial.begin(9600);
  pinMode(TOP, INPUT);
  pinMode(BOTTOM, INPUT);
  pinMode(LEFT, INPUT);
  pinMode(RIGHT, INPUT);
}

void loop() {
  left = digitalRead(LEFT);
  right = digitalRead(RIGHT);
  top = digitalRead(UP);
  bottom = digitalRead(DOWN);

  if(left != _left) {
    Serial.println(left == 0 ? LEFT : LEFT + CONSTANT;
    _left = left;
  }
  
  if(right != _right) {
    Serial.println(right == 0 ? RIGHT : RIGHT + CONSTANT;
    _right = right;
  }

  if(up != _up) {
    Serial.println(up == 0 ? UP : UP + CONSTANT;
    _up = up;
  }

  if(down != _down) {
    Serial.println(down == 0 ? DOWN : DOWN + CONSTANT;
    _down = down;
  }
  
  Serial.flush();
  /*if(val == 0 || reset == 1) {
    Serial.println(val);
    reset = (val == 0 ? 1 : 0);
  }*/
  delay(30);
}
