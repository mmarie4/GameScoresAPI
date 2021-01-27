CREATE TABLE public.players (
  device_id varchar,
  "name" varchar,
  country varchar
);

CREATE TABLE public.scores (
  id uuid,
  device_id varchar,
  distance int,
  duration int,
  coins_collected int,
  created_at timestamp
)
