String msg = "";
int laserPin = 3;

void setup() {
  pinMode(laserPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  while (Serial.available()) {
    if (Serial.available() > 0) {
      char c = Serial.read();
      if (c == '\n') {
        readMessage();
      } else {
        msg += c;
        //Serial.println("Current message: " + msg);
      }
    }
  }
}

void readMessage() {
  if (msg == "LaserOn") {
    digitalWrite(laserPin, HIGH);
    delay(100);
    Serial.println("TurnedLaserOn");
  } else if (msg == "LaserOff") {
    digitalWrite(laserPin, LOW);
    Serial.println("TurnedLaserOff");
  } else {
    //Serial.println("Unknown command: " + msg);
  }
  msg = "";
}
