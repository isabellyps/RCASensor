# RCASensor

## Projeto desenvolvido para receber eventos de sensores espalhados pelo Brasil, nas regiões norte, sul, sudeste e nordeste. 

### Projeto BackEnd

#### Pré-requisitos
```bash
# Clone este repositório
$ git clone https://gitlab.com/isabellyps/junior-analyst.git

# Configuração dotnet-ef
$ Para instalação execute o comando: dotnet tool install --global dotnet-ef
$ Para atualização execute o comando: dotnet tool update --global dotnet-ef

# Para criação do banco de dados
$ Alterar a connection string no arquivo RCASensorContext.cs de acordo com seu ambiente
$ Execute o comando: dotnet ef database update --project .\RCASensor.Repository

# Marque o projeto de inicialização
$ Selecione RCASensor.WebAPI e execute a solução

# Verificar a porta que inciou a aplicação
$ Como exemplo, se iniciar na porta:44369 - <https://localhost:44369/index.html>
```
#### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [.Net Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- [AutoMapper](https://automapper.org/)
- [Entity Framework](https://docs.microsoft.com/pt-br/ef/)
- [Swagger](https://swagger.io/)

### Projeto FrontEnd

#### Pré-requisitos
```bash
# Clone este repositório
$ git clone https://gitlab.com/isabellyps/junior-analyst.git

# Acesse a pasta do projeto no terminal/cmd
$ cd rca-sensor-frontend

# Instale as dependências
$ npm install

# Configurando a url da api
$ No arquivo environment.ts, em apiSettings.baseUrl coloque a porta em que a aplicação backend está sendo executada.

# Execute a aplicação em modo de desenvolvimento
$ npm start

# O servidor inciará na porta:4200 - acesse <http://localhost:4200>
```
#### 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [Angular](https://angular.io/)
- [Bootstrap](https://getbootstrap.com/docs/5.0/getting-started/introduction/)
- [Ngx-pagination](https://www.npmjs.com/package/ngx-pagination)
- [FontAwesome](https://fontawesome.com/)

### Ideias que eu gostaria de implementar

- O WebSocket
- Se tivesse mais tempo implentaria a criação de tabelas que se remete as entidades país, região, sensores.

### Autor
---

<a href="">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/56942690?s=460&u=4dae5a2c950a2ef889b597a769e3d8d7f23d1d65&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Isabelly Paganini Soarde</b></sub></a> <a href="https://isabellypersonalpage.netlify.app/" title="Personal Page">🚀</a>


Feito com ❤️ por Isabelly Paganini Soarde 👋🏽 Entre em contato!
