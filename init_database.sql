CREATE TABLE players {
  device_id varchar
  name varchar
  country varchar
}

CREATE TABLE scores {
  id uuid
  device_id varchar
  distance int
  duration int
  coins_collected int
  created_at timestamp
}
