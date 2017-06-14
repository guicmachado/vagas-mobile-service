using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VagasMobileService.Models;

namespace VagasMobileService.Repositories
{
    public class VagaRepository : IVagaRepository
    {
        private readonly List<Vaga> vagas = new List<Vaga>
        {
            new Vaga()
            {
                Codigo = 1,
                Titulo = "Analista de Sistemas Jr",
                Local = "Belo Horizonte",
                FormaContratacao = "CLT",
                Data = "03/06/2017",
                Empresa = "XY Consultoria",
                Cargo = new Cargo()
                {
                    Codigo = 1,
                    Descricao = "Analista"
                },
                Descricao = "Análise de sistemas e arquivos XML para atuar no suporte à produção em sistema de Seguros. Deverá realizar a contabilização diária dos faturamentos, baixa de prêmios e pagamento de comissões em sistema. Irá analisar e resolver problemas de baixa complexidade, escalonando quando necessário. Desejável conhecimento de SQL e Oracle para consultas à base e extração de informações."
            },

            new Vaga()
            {
                Codigo = 2,
                Titulo = "Analista de Sistemas Sr",
                Local = "São Paulo",
                FormaContratacao = "PJ",
                Data = "02/06/2017",
                Empresa = "Z Consultoria",
                Cargo = new Cargo()
                {
                    Codigo = 1,
                    Descricao = "Analista"
                },
                Descricao = "Levantamento e análise de requisitos. Estudar a viabilidade técnica dos novos projetos e propor alternativas. Desenvolvimento de protótipos, histórias de usuários, planos de testes e especificações funcionais. Ser capaz de propor soluções técnicas e arquiteturas. Dar suporte aos usuários para o refinamento do backlog do produto. Detalhar os itens do backlog de produto. Entender o funcionamento do sistema atual e auxiliar o time de operações nos incidentes diários. Boa comunicação verbal e escrita."
            },

            new Vaga()
            {
                Codigo = 3,
                Titulo = "Arquiteto de Solução Java",
                Local = "São Paulo",
                FormaContratacao = "CLT",
                Data = "03/06/2017",
                Empresa = "ABC S.A.",
                Cargo = new Cargo()
                {
                    Codigo = 2,
                    Descricao = "Arquiteto"
                },
                Descricao = "O profissional terá o papel de Arquiteto de Soluções/ Coordenador Técnico. Será responsável por coordenar o times de desenvolvimento Java e Portais Web Back: J2EE, SAML2, SOAP (WSDL), Oracle DataBase. Atuação com Back End e Front End. Possuir solida experiência em projetos de Java Web Portais. Ter forte conhecimento de WebLogic Application Server. Experiência em portais WLP (Weblogic Portal – portlets/jsp), WCS(Oracle Webcenter Sites), Oracle UCM, Frameworks responsivos, javascript/ajax, HTML/CSS."
            },

            new Vaga()
            {
                Codigo = 4,
                Titulo = "Arquiteto Mobile",
                Local = "Osasco",
                FormaContratacao = "PJ",
                Data = "03/02/2017",
                Empresa = "B Systems",
                Cargo = new Cargo()
                {
                    Codigo = 2,
                    Descricao = "Arquiteto"
                },
                Descricao = "Experiência em arquitetura de ambiente mobile. Atuar no desenvolvimento mobile(app) utilizando Android, iOS e outros. Diferencial ter atuado na estrutura de projetos Digitais na área de aplicativos para mobilidade. Diferencial experiência no seguimento financeiro/bancos."
            },

            new Vaga()
            {
                Codigo = 5,
                Titulo = "Arquiteto .NET",
                Local = "Campinas",
                FormaContratacao = "PJ",
                Data = "02/06/2017",
                Empresa = "W Group",
                Cargo = new Cargo()
                {
                    Codigo = 2,
                    Descricao = "Arquiteto"
                },
                Descricao = "Experiência em ambientes Microsoft, desenvolvimento de software em .Net(Desktop, Mobile, Web, Cloud), concepção e arquitetura de projetos de pequena, média e larga escala, APIs e interfaces de comunicação(HTTP, REST, SOAP, Micro Serviços), Entity Framework, Javascript e JQuery."
            },

            new Vaga()
            {
                Codigo = 6,
                Titulo = "Coordenador .NET",
                Local = "São Paulo",
                FormaContratacao = "PJ",
                Data = "03/06/2017",
                Empresa = "K One",
                Cargo = new Cargo()
                {
                    Codigo = 3,
                    Descricao = "Coordenador"
                },
                Descricao = "Experiência em automação de desenvolvimento e testes que serão feitas utilizando TDD. Esse líder atuará 70 do tempo com a gestão mesmo dos projetos e pessoas e 30 técnico no desenvolvimento. Experiência em C#, ASP.NET e SQL Server. Acompanhará a entrega da fábrica de software. Habilidade automação, TDD e Testes WEB."
            },

            new Vaga()
            {
                Codigo = 7,
                Titulo = "Coordenador de TI",
                Local = "São Paulo",
                FormaContratacao = "CLT",
                Data = "03/06/2017",
                Empresa = "TBA Systems",
                Cargo = new Cargo()
                {
                    Codigo = 3,
                    Descricao = "Coordenador"
                },
                Descricao = "Atuar com gestão de equipes utilizando boas práticas ITIL. Conhecimentos de ferramentas e práticas de qualidade como melhoria contínua (PDCA). Obrigatório conhecimento em implantação e sustentação de projetos na área de sistemas. Desejável certificação ITIL Foudation, ITIL Expert, Cobit Foudation e MCP."
            },

            new Vaga()
            {
                Codigo = 8,
                Titulo = "Gerente de TI",
                Local = "São Paulo",
                FormaContratacao = "CLT",
                Data = "22/05/2017",
                Empresa = "EX Group",
                Cargo = new Cargo()
                {
                    Codigo = 4,
                    Descricao = "Gerente"
                },
                Descricao = "Interagir com equipes técnicas de Infraestrutura de TI e Sistemas de Informação,para atender os problemas relacionados a área, buscando as soluções. Verificar constantemente o cumprimento dos níveis de SLAs junto as áreas atendidas e seus fornecedores. Coordenar equipes de Service Desk e Laboratórios pedagógicos de informática, monitorar os acordos de níveis de serviços(SLA),acompanhar os relatórios de indicadores de performance, elaborar propostas de plano de ação para melhoria continua. Administrar as equipes de coordenadores de TI(Service Desk e Laboratórios de informática). Elaborar e Definir normas e procedimentos padrão de atendimentos das unidades."
            },

            new Vaga()
            {
                Codigo = 9,
                Titulo = "Programador Android Pl",
                Local = "Barueri",
                FormaContratacao = "CLT",
                Data = "03/06/2017",
                Empresa = "H Solutions",
                Cargo = new Cargo()
                {
                    Codigo = 5,
                    Descricao = "Programador"
                },
                Descricao = "Experiência com o Android SDK, programação multithread, ferramentas de desempenho Android e framework de teste. Experiência com SQL e banco de dados relacional(SQLite, Postgres, MySQL, Oracle). Experiência com software de controle de versão distribuído (pref. Git), e interface de linha de comando (CLI). Familiaridade com os protocolos de rede, TCP/IP, XML, JSON e web services REST. Familiaridade com processo de desenvolvimento de software ágil(como XP, Scrum e Kanban)."
            },

            new Vaga()
            {
                Codigo = 10,
                Titulo = "Programador Java Pl",
                Local = "São Paulo",
                FormaContratacao = "CLT",
                Data = "03/06/2017",
                Empresa = "iSolutions",
                Cargo = new Cargo()
                {
                    Codigo = 5,
                    Descricao = "Programador"
                },
                Descricao = "Experiência com programação Java, análise de requisitos, especificações e demais etapas do ciclo de vida de um produto de software. Responsável pela Implantação de produtos Oracle e Framework Struts. Conhecimentos em desenvolvimento em programação para Web, incluindo HTML 5,CSS3 e JavaScript, programação, linguagem orientada a objetos (Java), padrões de projeto (Facade,DAO, Service e MVC),bancos de dados relacionais, linguagem SQL, características de software embarcado (aplicativos) e sobre métodos ágeis (Scrum / XP)."
            },

            new Vaga()
            {
                Codigo = 11,
                Titulo = "Programador .NET Jr",
                Local = "Rio de Janeiro",
                FormaContratacao = "CLT",
                Data = "01/06/2017",
                Empresa = "K Systems",
                Cargo = new Cargo()
                {
                    Codigo = 5,
                    Descricao = "Programador"
                },
                Descricao = "Experiência em .NET 3, 3.5, 4 ou superior, Windows Forms, Web Forms, jQuery, Web Services. Graduação completa nos cursos relacionados com: Análise e Desenvolvimento de Sistemas, Ciências da Computação, Engenharia da Computação ou cursos correlatos. Conhecimento em Visual Studio 2010, 2013 ou 2015. Conhecimento na metodologia MVC. Conhecimento no banco de dados SQL Server."
            },

            new Vaga()
            {
                Codigo = 12,
                Titulo = "Programador .NET Sr",
                Local = "Barueri",
                FormaContratacao = "PJ",
                Data = "28/05/2017",
                Empresa = "CP Consultoria",
                Cargo = new Cargo()
                {
                    Codigo = 5,
                    Descricao = "Programador"
                },
                Descricao = "Grande conhecimento em .NET 3, 3.5, 4 ou superior. Grande conhecimento em Visual Studio 2010, 2013 ou 2015. Grande conhecimento na metodologia MVC. Vasta experiência e vivência com Windows Forms, Web Forms, jQuery, Web Services. Grande conhecimento no banco de dados SQL Server. Vasta experiência e vivência com desenvolvimento. Boa comunicação verbal e escrita."
            },

            new Vaga()
            {
                Codigo = 13,
                Titulo = "Programador Java Sr",
                Local = "Santos",
                FormaContratacao = "PJ",
                Data = "20/05/2017",
                Empresa = "V Group",
                Cargo = new Cargo()
                {
                    Codigo = 5,
                    Descricao = "Programador"
                },
                Descricao = "Experiência em desenvolvimento Java com os seguintes frameworks: Jquery, JavaScript, JSF 2.1, PrimeFaces, EJB 3.0, JPA, JavaFX(Desejável). Capacidade de compreender modelagens de banco de dados e formular instruções SQL. Boa capacidade analítica e em modelagem de soluções."
            }
        };

        public async Task<List<Vaga>> GetVagaByCargoCodigoAsync(int cargoCodigo)
        {
            return await Task.FromResult(vagas.Where(c => c.Cargo.Codigo.Equals(cargoCodigo)).ToList());
        }

        public async Task<List<Vaga>> GetVagaAsync()
        {
            return await Task.FromResult(vagas);
        }
    }
}