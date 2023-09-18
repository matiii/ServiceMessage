
docker compose -f .\kafka-compose.yml up -d

kafka-topics --create --topic bid-topic --bootstrap-server localhost:9092
kafka-topics --create --topic ask-topic --bootstrap-server localhost:9092