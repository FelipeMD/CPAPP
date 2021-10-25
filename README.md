# CPAPP

## Utilizando Mensageria com RabbitMQ

1. Usando o Chocolatey execute o comando " choco install rabbitmq "
2. Após concluir a instalação localizar o caminho " RabbitMQ  Server\rabbitmq_server_version\sbin " utilizando o terminal do RabbitMQ e 
executar o comando " rabbitmq-plugins enable rabbitmq_management " para habilitar o Dashboard.
<p>Acesso ao dashboard: http://localhost:15672/#/ - Username: guest - Password: guest</p>
3. Sempre executar API.CONSUMER e API juntas.

## Utilizando Cache com Redis - Necessário Docker

1.Criar o contêiner no Docker.
<p>" docker run --name local-redis -p 6379:6379 -d redis "</p>
2. Para entrar no contêiner.
<p>" docker exec -it local-redis sh "</p>
3. Para testar
<p> " docker ps " - " redis-cli " - " ping " </p>
