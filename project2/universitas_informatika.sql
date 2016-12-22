-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2016 at 02:23 PM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `universitas_informatika`
--

-- --------------------------------------------------------

--
-- Table structure for table `dosen`
--

CREATE TABLE IF NOT EXISTS `dosen` (
  `id_dosen` int(11) NOT NULL,
  `nama_dosen` varchar(45) DEFAULT NULL,
  `email_dosen` varchar(45) DEFAULT NULL,
  `User_name` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `link_fb` varchar(45) DEFAULT NULL,
  `wibsite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `informasi`
--

CREATE TABLE IF NOT EXISTS `informasi` (
  `id_informasi` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL DEFAULT '0',
  `MATA_KULIAH_id_matakuliah` int(11) NOT NULL DEFAULT '0',
  `MATA_KULIAH_DOSEN_id_dosen` int(11) NOT NULL DEFAULT '0',
  `judul` varchar(45) DEFAULT NULL,
  `info` varchar(45) DEFAULT NULL,
  `tanggal` varchar(45) DEFAULT NULL,
  `hari` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_informasi`,`DOSEN_id_dosen`,`MATA_KULIAH_id_matakuliah`,`MATA_KULIAH_DOSEN_id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE IF NOT EXISTS `mahasiswa` (
  `id_mahasiswa` int(11) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `nama_mahasiswa` varchar(45) DEFAULT NULL,
  `nim_mahasiswa` varchar(45) DEFAULT NULL,
  `tgl_lahir_mhs` varchar(45) DEFAULT NULL,
  `email_mhs` varchar(45) DEFAULT NULL,
  `alamat_mhs` varchar(45) DEFAULT NULL,
  `notelp_mhs` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_mahasiswa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mata_kuliah`
--

CREATE TABLE IF NOT EXISTS `mata_kuliah` (
  `id_matakuliah` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL,
  `sks` varchar(45) DEFAULT NULL,
  `MATA_KULIAH` varchar(45) DEFAULT NULL,
  `kode` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_matakuliah`,`DOSEN_id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE IF NOT EXISTS `nilai` (
  `id_nilai` int(11) NOT NULL,
  `PERSERTA_MK_id_peserta` int(11) NOT NULL,
  `tugas` varchar(22) DEFAULT NULL,
  `uts` varchar(22) DEFAULT NULL,
  `uas` varchar(22) DEFAULT NULL,
  PRIMARY KEY (`id_nilai`,`PERSERTA_MK_id_peserta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `peserta_mk`
--

CREATE TABLE IF NOT EXISTS `peserta_mk` (
  `id_perserta` int(11) NOT NULL,
  `MAHASISWA_id_mahasiswa` int(11) NOT NULL,
  `DOSEN_id_dosen` int(11) NOT NULL,
  `MATA_KULIAH_id_matakuliah` int(11) NOT NULL,
  `NILAI_id_nilai` int(11) NOT NULL,
  PRIMARY KEY (`id_perserta`,`MAHASISWA_id_mahasiswa`,`DOSEN_id_dosen`,`MATA_KULIAH_id_matakuliah`,`NILAI_id_nilai`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
