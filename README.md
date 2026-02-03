# 🚀 ASP.NET Core + .NET Aspire — Estudo de Arquitetura Distribuída

Este repositório contém um **projeto de estudo prático** utilizando **ASP.NET Core** com **.NET Aspire**, focado em **arquitetura distribuída**, **observabilidade**, **resiliência** e **performance**, incluindo cache distribuído com **Redis** e banco de dados **PostgreSQL**.

O objetivo é demonstrar, de forma prática, como o **.NET Aspire simplifica o desenvolvimento, configuração e observabilidade** de aplicações modernas compostas por múltiplos serviços.

---

## 🧠 O que foi estudado neste projeto

Este projeto foi desenvolvido seguindo um tutorial focado em **.NET Aspire**, cobrindo os seguintes tópicos:

### 🌟 .NET Aspire — Fundamentos

- Introdução ao **.NET Aspire**
- Conceitos de **AppHost** e **Application Model**
- Organização e orquestração de aplicações distribuídas

### 🧩 Integrações

- Uso de **Hosting Integrations**
- Uso de **Client Integrations**
- Adição de projetos .NET ao **Application Model**
- Comunicação entre serviços gerenciados pelo Aspire

### ♻️ Resiliência

- Configuração de **políticas de resiliência**
- Preparação da aplicação para falhas transitórias
- Boas práticas para ambientes distribuídos

### ❤️ Health Checks

- Implementação de **Health Checks**
- Monitoramento da saúde dos serviços
- Integração com o painel do Aspire

### 🔍 Observabilidade

- **Tracing distribuído**
- Logs estruturados
- Métricas de desempenho
- Visualização centralizada pelo **Aspire Dashboard**

---

## ⚡ Performance com Cache Distribuído

Além do tutorial base, este projeto foi estendido com:

### 🚀 Redis Cache

- Implementação de **cache distribuído com Redis**
- Comparação de performance entre:
  - Consultas diretas ao **PostgreSQL**
  - Consultas atendidas pelo **Redis Cache**
- Análise do impacto do cache utilizando **traces**
- Visualização clara da redução de tempo de resposta dos endpoints

Essa abordagem permitiu observar, de forma prática, os **ganhos reais de performance** em um cenário comum de APIs REST.

---

## 🗄️ Persistência de Dados

- Substituição do **SQLite** por **PostgreSQL**
- Integração do PostgreSQL ao **.NET Aspire**
- Gerenciamento de dependências e conexão via Application Model
- Uso de Entity Framework Core com Postgres

---

## 🛠️ Tecnologias Utilizadas

- **.NET 10**
- **ASP.NET Core**
- **.NET Aspire**
- **Entity Framework Core**
- **PostgreSQL**
- **Redis**
- **OpenTelemetry**
- **REST APIs**
- **Dependency Injection**

---

## ▶️ Executando o projeto

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/)
- Docker (para Redis e PostgreSQL, se aplicável)

### Execução

```bash
dotnet restore
dotnet run --project .\GameStore.AppHost\
```

O Aspire Dashboard será iniciado observe a URL gerada já com o token de acesso algo parecido com:
Login to the dashboard at https://localhost:17142/login?t=b04c905fd70918ed0fe04f5f62ba8d3b

A partir do Dashboard, você pode:

- Visualizar serviços
- Acompanhar health checks
- Analisar traces e métricas
- Comparar chamadas com e sem cache

---

## 🎯 Objetivo do Repositório

Este repositório tem como finalidade:

- Estudar .NET Aspire na prática
- Entender aplicações distribuídas no ecossistema .NET
- Aplicar observabilidade desde o início
- Analisar impacto real de cache distribuído
- Servir como material técnico e portfólio profissional

---

## 👨‍💻 Autor

Marcelo Casamassa

Desenvolvedor de Software | Backend | .NET | Arquitetura de APIs

📌 Projeto desenvolvido com foco em aprendizado prático e evolução técnica contínua.

### ⭐ Observação

Este projeto é educacional e pode ser expandido futuramente com:

- Novos serviços
- Mensageria
- Circuit Breakers avançados
- Deploy em cloud
