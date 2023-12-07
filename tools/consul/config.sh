#!/bin/bash
# Infrastructure
docker exec -it consul consul services register -name=RabbitMQ -address=localhost
docker exec -it consul consul services register -name=SecretManager -address=http://localhost -port=8200
docker exec -it consul consul services register -name=MySql -address=20.96.59.200 -port=3306
docker exec -it consul consul services register -name=MongoDb -address=20.96.59.194 -port=27017
docker exec -it consul consul services register -name=Graylog --address=localhost -port=12201

# Services
docker exec -it consul consul services register -name=EmailsApi -address=http://localhost -port=60120
docker exec -it consul consul services register -name=ProductsApiWrite -address=https://localhost -port=60320
docker exec -it consul consul services register -name=ProductsApiRead -address=https://localhost -port=60321
docker exec -it consul consul services register -name=OrdersApi -address=http://localhost -port=60220
docker exec -it consul consul services register -name=SubscriptionsApi -address=http://localhost -port=60420
