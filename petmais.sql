-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 06-Maio-2021 às 03:10
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `petmais`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(9) NOT NULL,
  `nomeCliente` varchar(50) DEFAULT NULL,
  `enderecoCliente` varchar(80) DEFAULT NULL,
  `nrresCliente` int(6) DEFAULT NULL,
  `bairroCliente` varchar(25) DEFAULT NULL,
  `complCliente` varchar(50) DEFAULT NULL,
  `cepCliente` varchar(10) DEFAULT NULL,
  `cidadeCliente` varchar(45) DEFAULT NULL,
  `estadoCliente` varchar(2) DEFAULT NULL,
  `tel1Cliente` varchar(15) DEFAULT NULL,
  `tel2Cliente` varchar(15) DEFAULT NULL,
  `tel3Cliente` varchar(15) DEFAULT NULL,
  `pessoaCliente` varchar(1) DEFAULT NULL,
  `tpindCliente` varchar(3) DEFAULT NULL,
  `identCliente` varchar(20) DEFAULT NULL,
  `idUsuarioCli` int(9) DEFAULT NULL,
  `dtcadCliente` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nomeCliente`, `enderecoCliente`, `nrresCliente`, `bairroCliente`, `complCliente`, `cepCliente`, `cidadeCliente`, `estadoCliente`, `tel1Cliente`, `tel2Cliente`, `tel3Cliente`, `pessoaCliente`, `tpindCliente`, `identCliente`, `idUsuarioCli`, `dtcadCliente`) VALUES
(1, 'CLIENTE 01 1111111111111111', '111111111111', 0, '11111', NULL, '11111', '11111', 'TO', '11111', '11111', '111111', '1', NULL, '1111', 0, '0001-01-01'),
(2, 'CLIENTE 02', '2222', 0, '2222', NULL, '222', '22222', 'ES', '2222', '2222', '2222', '2', NULL, '22222', 0, '0001-01-01');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `idFornecedor` int(9) NOT NULL,
  `nomeFornecedor` varchar(50) DEFAULT NULL,
  `enderecoFornecedor` varchar(80) DEFAULT NULL,
  `nrresFornecedor` int(6) DEFAULT NULL,
  `bairroFornecedor` varchar(25) DEFAULT NULL,
  `complFornecedor` varchar(50) DEFAULT NULL,
  `cepFornecedor` varchar(10) DEFAULT NULL,
  `cidadeFornecedor` varchar(45) DEFAULT NULL,
  `estadoFornecedor` varchar(2) DEFAULT NULL,
  `tel1Fornecedor` varchar(15) DEFAULT NULL,
  `tel2Fornecedor` varchar(15) DEFAULT NULL,
  `tel3Fornecedor` varchar(15) DEFAULT NULL,
  `pessoaFornecedor` varchar(1) DEFAULT NULL,
  `tpindFornecedor` varchar(3) DEFAULT NULL,
  `identFornecedor` varchar(20) DEFAULT NULL,
  `idUsuarioFor` int(9) DEFAULT NULL,
  `dtcadFornecedor` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`idFornecedor`, `nomeFornecedor`, `enderecoFornecedor`, `nrresFornecedor`, `bairroFornecedor`, `complFornecedor`, `cepFornecedor`, `cidadeFornecedor`, `estadoFornecedor`, `tel1Fornecedor`, `tel2Fornecedor`, `tel3Fornecedor`, `pessoaFornecedor`, `tpindFornecedor`, `identFornecedor`, `idUsuarioFor`, `dtcadFornecedor`) VALUES
(1, 'FORNECEDOR 22222', '222222', 0, '222222', NULL, '22222', '222222', 'MG', '2222222', '2222222', '22222', '1', NULL, '222222', 0, '0001-01-01'),
(2, 'FORNECEDOR 3333333333333333333333333', '333333', 0, '33333', NULL, '3333', '33333', 'RN', '33333', '33333', '333333', '2', NULL, '3333333333333333333', 0, '0001-01-01');

-- --------------------------------------------------------

--
-- Estrutura da tabela `servico`
--

CREATE TABLE `servico` (
  `idServico` int(15) NOT NULL,
  `nomeServico` varchar(80) DEFAULT NULL,
  `detalheServico` varchar(250) DEFAULT NULL,
  `valorServico` double(12,2) DEFAULT NULL,
  `fotoServico` varchar(45) DEFAULT NULL,
  `tipoServico` varchar(15) DEFAULT NULL,
  `cidadeServico` varchar(30) DEFAULT NULL,
  `estadoServico` varchar(2) DEFAULT NULL,
  `idForServico` int(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servico`
--

INSERT INTO `servico` (`idServico`, `nomeServico`, `detalheServico`, `valorServico`, `fotoServico`, `tipoServico`, `cidadeServico`, `estadoServico`, `idForServico`) VALUES
(1, 'BANHO 01 TIPO DE BANHO COM ESPUMA', 'BANHO COM ESPUMA DE SHAMPPO DE COCO', 0.00, 'SERBanho_20215522651.jpg', 'Banho', '22222222222222222222', 'AC', 1),
(2, 'BANHO 02334343434', 'TSTES TESTE YES', 0.00, 'SERBanho_2021552226.jpg', 'Banho', 'MANAUS', 'AM', 1),
(3, 'VETERINARIO 00002', 'VETERUNARUI', 0.00, 'SERVeterinario_20215522680.jpg', 'Veterinario', 'VITORIOA', 'ES', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `emailUsuario` varchar(45) DEFAULT NULL,
  `loginUsuario` varchar(45) DEFAULT NULL,
  `senhaUsuario` varchar(25) DEFAULT NULL,
  `tipoUsuario` varchar(1) DEFAULT NULL,
  `dtcadUsuario` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `emailUsuario`, `loginUsuario`, `senhaUsuario`, `tipoUsuario`, `dtcadUsuario`) VALUES
(1, 'silvio@terra.com.br', 'SILVIO', '123', '1', '2021-05-05'),
(2, 'silvio@terra.com.br', 'USER1', '123', '2', '2021-05-05');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Índices para tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`idFornecedor`);

--
-- Índices para tabela `servico`
--
ALTER TABLE `servico`
  ADD PRIMARY KEY (`idServico`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `idFornecedor` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `servico`
--
ALTER TABLE `servico`
  MODIFY `idServico` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
