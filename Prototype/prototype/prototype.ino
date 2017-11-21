#define UP 0
#define DOWN 1
#define LEFT 2
#define RIGHT 3
#define CONSTANT 4

int left = 0, right = 0, up = 0, down = 0, _left = -1, _right = -1, _up = -1, _down = -1;
int reset = 0;

void setup() {
  Serial.begin(9600);
  pinMode(UP + 2, INPUT);
  pinMode(DOWN + 2, INPUT);
  pinMode(LEFT + 2, INPUT);
  pinMode(RIGHT + 2, INPUT);
}

void loop() {
  left = digitalRead(LEFT + 2);
  right = digitalRead(RIGHT + 2);
  up = digitalRead(UP + 2);
  down = digitalRead(DOWN + 2);
  
  if(left != _left) {
    Serial.println(left == 0 ? LEFT : LEFT + CONSTANT);
    _left = left;
  }

  if(right != _right) {
    Serial.println(right == 0 ? RIGHT : RIGHT + CONSTANT);
    _right = right;
  }

  if(up != _up) {
    Serial.println(up == 0 ? UP : UP + CONSTANT);
    _up = up;
  }

  if(down != _down) {
    Serial.println(down == 0 ? DOWN : DOWN + CONSTANT);
    _down = down;
  }
  
  Serial.flush();

/*Old working code*/
  /*if(val == 0 || reset == 1) {
    Serial.println(val);
    reset = (val == 0 ? 1 : 0);
  }*/
  delay(30);
}
