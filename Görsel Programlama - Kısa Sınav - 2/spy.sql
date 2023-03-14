-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 20 Ara 2021, 20:26:31
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `spy`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

DROP TABLE IF EXISTS `kullanicilar`;
CREATE TABLE IF NOT EXISTS `kullanicilar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(255) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`id`, `kullanici_adi`, `sifre`) VALUES
(1, 'spy', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `stoklar`
--

DROP TABLE IF EXISTS `stoklar`;
CREATE TABLE IF NOT EXISTS `stoklar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `yiyecek` int(10) DEFAULT NULL,
  `icecek` int(10) DEFAULT NULL,
  `temizlik` int(10) DEFAULT NULL,
  `kayit_tarihi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `stoklar`
--

INSERT INTO `stoklar` (`id`, `yiyecek`, `icecek`, `temizlik`, `kayit_tarihi`) VALUES
(1, 10, 10, 10, '2021-12-20 16:03:41'),
(3, 15, 20, 25, '2021-12-20 17:23:14'),
(4, 1, 1, 1, '2021-12-20 19:43:24'),
(5, 1, 1, 1, '2021-12-20 19:43:25'),
(6, 1, 1, 1, '2021-12-20 19:43:25'),
(7, 1, 1, 1, '2021-12-20 19:43:25'),
(8, 1, 1, 1, '2021-12-20 19:43:25'),
(9, 1, 1, 1, '2021-12-20 19:43:25'),
(10, 1, 1, 1, '2021-12-20 19:43:25'),
(11, 1, 1, 1, '2021-12-20 19:43:26'),
(12, 1, 1, 1, '2021-12-20 19:43:26'),
(13, 1, 1, 1, '2021-12-20 19:43:26'),
(14, 0, 0, 0, '2021-12-20 20:07:09'),
(15, 0, 0, 0, '2021-12-20 20:07:12'),
(16, 0, 15, 0, '2021-12-20 20:07:14'),
(17, 0, -15, 0, '2021-12-20 20:09:40');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
