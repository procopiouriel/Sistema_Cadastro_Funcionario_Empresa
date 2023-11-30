create database Empresa;
use Empresa;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(300),
cpf_fun varchar(20),
rg_fun varchar(20),
dataNascimento_fun date,
funcao_fun varchar(300),
telefone_fun varchar(20),
email_fun varchar(100),
salario_fun double,
estadoCivil_fun varchar(100),
estado_fun varchar(200),
cidade_fun varchar(200),
endereco_fun varchar(400)
);
select * from Funcionario;

CREATE TABLE Empresa (
    id_emp INT PRIMARY KEY AUTO_INCREMENT,
    razaoSocial_emp VARCHAR(300),
    nomeFantasia_emp VARCHAR(300),
    cnpj_emp VARCHAR(20),
    proprietario_emp VARCHAR(200),
    cpf_emp VARCHAR(20),
    telefone_emp VARCHAR(30),
    estado_emp VARCHAR(200),
    cidade_emp VARCHAR(200),
    endereco_emp VARCHAR(400),
    situacaoCadastral_emp VARCHAR(200),
    naturezaJuridica_emp VARCHAR(200),
    dataInicio_emp VARCHAR(200),
    tipo_emp VARCHAR(200),
    regimeTributario_emp VARCHAR(200),
    porteEmpresa_emp VARCHAR(100),
    capitalSocial_emp DOUBLE
);