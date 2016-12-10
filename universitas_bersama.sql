-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2016 at 01:52 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `universitas_bersama`
--

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE IF NOT EXISTS `dosen` (
  `id_dosen` int(11) NOT NULL,
  `nama_dosen` varchar(45) DEFAULT NULL,
  `email_dosen` varchar(45) DEFAULT NULL,
  `UserName` varchar(45) DEFAULT NULL,
  `pasword` varchar(45) DEFAULT NULL,
  `link_fb` varchar(45) DEFAULT NULL,
  `wibsite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `informasi`
--

CREATE TABLE IF NOT EXISTS `informasi` (
  `id_informasi` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL,
  `MATA_KULIAH_id_matakuliah` int(11) NOT NULL,
  `judul` varchar(45) DEFAULT NULL,
  `info` varchar(45) DEFAULT NULL,
  `tanggal` varchar(45) DEFAULT NULL,
  `hari` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_informasi`,`DOSEN_id_dosen`,`MATA_KULIAH_id_matakuliah`),
  KEY `fk_INFORMASI_MATA_KULIAH1_idx` (`MATA_KULIAH_id_matakuliah`),
  KEY `fk_INFORMASI_DOSEN1_idx` (`DOSEN_id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE IF NOT EXISTS `mahasiswa` (
  `id MAHASISWA` int(11) NOT NULL DEFAULT '0',
  `username` varchar(45) DEFAULT NULL,
  `pasword` varchar(45) DEFAULT NULL,
  `nama_mhs` varchar(45) DEFAULT NULL,
  `nim_mhs` varchar(45) DEFAULT NULL,
  `tgl_lahir_mhs` varchar(45) DEFAULT NULL,
  `email_mhs` varchar(45) DEFAULT NULL,
  `alamat_mhs` varchar(45) DEFAULT NULL,
  `no_telp` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id MAHASISWA`)
) ENGINE=InnoDB DEFAULT CHARSET=cp850;

-- --------------------------------------------------------

--
-- Table structure for table `mata_kuliah`
--

CREATE TABLE IF NOT EXISTS `mata_kuliah` (
  `id_matakuliah` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL,
  `MATA_KULIAH` varchar(45) DEFAULT NULL,
  `sks` varchar(45) DEFAULT NULL,
  `kode` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_matakuliah`,`DOSEN_id_dosen`),
  KEY `fk_MATA_KULIAH_DOSEN1_idx` (`DOSEN_id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE IF NOT EXISTS `nilai` (
  `id_nilai` int(11) NOT NULL,
  `PESERTA MK_id_peserta` int(11) NOT NULL,
  `tugas` varchar(45) DEFAULT NULL,
  `uts` varchar(45) DEFAULT NULL,
  `uas` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_nilai`,`PESERTA MK_id_peserta`),
  KEY `fk_NILAI_PESERTA MK1_idx` (`PESERTA MK_id_peserta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `peserta mk`
--

CREATE TABLE IF NOT EXISTS `peserta mk` (
  `id_peserta` int(11) NOT NULL,
  `MAHASISWA_id MAHASISWA` int(11) NOT NULL,
  `MATA_KULIAH_id_matakuliah` int(11) NOT NULL,
  `MATA_KULIAH_DOSEN_id_dosen` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL,
  PRIMARY KEY (`id_peserta`,`MAHASISWA_id MAHASISWA`,`MATA_KULIAH_id_matakuliah`,`MATA_KULIAH_DOSEN_id_dosen`,`DOSEN_id_dosen`),
  KEY `fk_PESERTA MK_MAHASISWA1_idx` (`MAHASISWA_id MAHASISWA`),
  KEY `fk_PESERTA MK_MATA_KULIAH1_idx` (`MATA_KULIAH_id_matakuliah`,`MATA_KULIAH_DOSEN_id_dosen`),
  KEY `fk_PESERTA MK_DOSEN1_idx` (`DOSEN_id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `informasi`
--
ALTER TABLE `informasi`
  ADD CONSTRAINT `fk_INFORMASI_MATA_KULIAH1` FOREIGN KEY (`MATA_KULIAH_id_matakuliah`) REFERENCES `mata_kuliah` (`id_matakuliah`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_INFORMASI_DOSEN1` FOREIGN KEY (`DOSEN_id_dosen`) REFERENCES `dosen` (`id_dosen`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `mata_kuliah`
--
ALTER TABLE `mata_kuliah`
  ADD CONSTRAINT `fk_MATA_KULIAH_DOSEN1` FOREIGN KEY (`DOSEN_id_dosen`) REFERENCES `dosen` (`id_dosen`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `nilai`
--
ALTER TABLE `nilai`
  ADD CONSTRAINT `fk_NILAI_PESERTA MK1` FOREIGN KEY (`PESERTA MK_id_peserta`) REFERENCES `peserta mk` (`id_peserta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `peserta mk`
--
ALTER TABLE `peserta mk`
  ADD CONSTRAINT `fk_PESERTA MK_MAHASISWA1` FOREIGN KEY (`MAHASISWA_id MAHASISWA`) REFERENCES `mahasiswa` (`id MAHASISWA`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_PESERTA MK_MATA_KULIAH1` FOREIGN KEY (`MATA_KULIAH_id_matakuliah`, `MATA_KULIAH_DOSEN_id_dosen`) REFERENCES `mata_kuliah` (`id_matakuliah`, `DOSEN_id_dosen`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_PESERTA MK_DOSEN1` FOREIGN KEY (`DOSEN_id_dosen`) REFERENCES `dosen` (`id_dosen`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
