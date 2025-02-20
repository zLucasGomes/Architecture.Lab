# Architecture.Lab (Em Progresso) 🏗️  

**Architecture.Lab** é um projeto laboratorial criado para estudar e comparar diferentes **arquiteturas de software**. Ele contém **mini projetos** independentes, cada um implementando uma abordagem arquitetural específica, permitindo aprendizado prático e aplicação de boas práticas.  

## 📌 Arquiteturas Implementadas  

### 🔹 DDD (Domain-Driven Design)  
- Organização em camadas: **Domain, Application, Infrastructure**.  
- Uso de **Entidades, Value Objects e Repositories**.  
- Separação clara entre regras de negócio e implementação técnica.  

### 🔹 EDA (Event-Driven Architecture)  
- Comunicação assíncrona via eventos.  
- Uso de **Message Brokers** como Azure Service Bus.  
- Publishers e Consumers trabalhando de forma desacoplada.  

### 🔹 Serverless  
- Uso de **Funções Serverless (Azure Functions)**.  
- Escalabilidade automática e redução de custos com servidores.  
- Ideal para tarefas sob demanda, como processamento de imagens e notificações.  

### 🔹 Hexagonal (Ports & Adapters)  
- Independência de frameworks e tecnologias externas.  
- Camadas de **Aplicação, Domínio, Adapters (Driven e Driving Ports)**.  
- Permite trocar bancos de dados ou interfaces sem alterar regras de negócio.  

### 🔹 Layered (Arquitetura em Camadas)  
- Estrutura clássica: **Controller → Service → Repository → Database**.  
- Facilidade de organização, porém pode gerar alto acoplamento.  
- Muito utilizada em aplicações monolíticas tradicionais.  

### 🔹 Microservices  
- Separação de funcionalidades em **serviços independentes**.  
- Comunicação via **REST, gRPC ou Mensageria**.  
- Permite escalabilidade individual de cada serviço.  

## 🎯 Objetivo  
Demonstrar **boas práticas de arquitetura** e facilitar o entendimento das diferentes abordagens, servindo como um guia para arquiteturas modernas e escaláveis. 🚀  

---
💡 **Tecnologias utilizadas**: C#, .NET, Azure Functions, Service Bus.  
