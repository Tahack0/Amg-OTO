CREATE DATABASE IF NOT EXISTS amg_oto_db;
USE amg_oto_db;
SET FOREIGN_KEY_CHECKS=0;

CREATE TABLE `adminler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `olusturma_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `kullanici_adi` (`kullanici_adi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `arac_markalari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `marka_adi` varchar(50) NOT NULL,
  `ulke` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `arac_modelleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `marka_id` int NOT NULL,
  `model_adi` varchar(50) NOT NULL,
  `motor_tipi` varchar(30) DEFAULT NULL,
  `nesil` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `marka_id` (`marka_id`),
  CONSTRAINT `arac_modelleri_ibfk_1` FOREIGN KEY (`marka_id`) REFERENCES `arac_markalari` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `araclar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `musteri_id` int NOT NULL,
  `model_id` int NOT NULL,
  `yil` int DEFAULT NULL,
  `plaka` varchar(20) NOT NULL,
  `sase_no` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `musteri_id` (`musteri_id`),
  KEY `model_id` (`model_id`),
  CONSTRAINT `araclar_ibfk_1` FOREIGN KEY (`musteri_id`) REFERENCES `musteriler` (`id`),
  CONSTRAINT `araclar_ibfk_2` FOREIGN KEY (`model_id`) REFERENCES `arac_modelleri` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `faturalar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `servis_id` int NOT NULL,
  `kdv_orani` decimal(4,2) DEFAULT '18.00',
  `toplam_tutar` decimal(10,2) NOT NULL,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `servis_id` (`servis_id`),
  CONSTRAINT `faturalar_ibfk_1` FOREIGN KEY (`servis_id`) REFERENCES `servis_kayitlari` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `iscilikler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `iscilik_adi` varchar(100) NOT NULL,
  `fiyat` decimal(10,2) NOT NULL,
  `tahmini_sure` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `islem_log` (
  `id` int NOT NULL AUTO_INCREMENT,
  `admin_id` int NOT NULL,
  `islem` varchar(255) NOT NULL,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `admin_id` (`admin_id`),
  CONSTRAINT `islem_log_ibfk_1` FOREIGN KEY (`admin_id`) REFERENCES `adminler` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `musteriler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  `telefon` varchar(20) NOT NULL,
  `eposta` varchar(80) DEFAULT NULL,
  `kayit_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `odemeler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fatura_id` int NOT NULL,
  `odeme_turu` enum('nakit','kart','havale','veresiye') NOT NULL,
  `odenen_tutar` decimal(10,2) NOT NULL,
  `odeme_tarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fatura_id` (`fatura_id`),
  CONSTRAINT `odemeler_ibfk_1` FOREIGN KEY (`fatura_id`) REFERENCES `faturalar` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `parca_kategorileri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `kategori_adi` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `parcalar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `parca_adi` varchar(100) NOT NULL,
  `parca_kodu` varchar(50) NOT NULL,
  `kategori_id` int DEFAULT NULL,
  `alis_fiyati` decimal(10,2) NOT NULL,
  `satis_fiyati` decimal(10,2) NOT NULL,
  `tedarikci` varchar(100) DEFAULT NULL,
  `stok_adedi` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `parca_kodu` (`parca_kodu`),
  KEY `kategori_id` (`kategori_id`),
  CONSTRAINT `parcalar_ibfk_1` FOREIGN KEY (`kategori_id`) REFERENCES `parca_kategorileri` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `servis_iscilikleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `servis_id` int NOT NULL,
  `iscilik_id` int NOT NULL,
  `fiyat` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `servis_id` (`servis_id`),
  KEY `iscilik_id` (`iscilik_id`),
  CONSTRAINT `servis_iscilikleri_ibfk_1` FOREIGN KEY (`servis_id`) REFERENCES `servis_kayitlari` (`id`),
  CONSTRAINT `servis_iscilikleri_ibfk_2` FOREIGN KEY (`iscilik_id`) REFERENCES `iscilikler` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `servis_kayitlari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `arac_id` int NOT NULL,
  `durum` enum('acik','tamamlandi','iptal') DEFAULT 'acik',
  `notlar` text,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `arac_id` (`arac_id`),
  CONSTRAINT `servis_kayitlari_ibfk_1` FOREIGN KEY (`arac_id`) REFERENCES `araclar` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `servis_parcalari` (
  `id` int NOT NULL AUTO_INCREMENT,
  `servis_id` int NOT NULL,
  `parca_id` int NOT NULL,
  `adet` int NOT NULL,
  `birim_fiyat` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `servis_id` (`servis_id`),
  KEY `parca_id` (`parca_id`),
  CONSTRAINT `servis_parcalari_ibfk_1` FOREIGN KEY (`servis_id`) REFERENCES `servis_kayitlari` (`id`),
  CONSTRAINT `servis_parcalari_ibfk_2` FOREIGN KEY (`parca_id`) REFERENCES `parcalar` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `stok_hareketleri` (
  `id` int NOT NULL AUTO_INCREMENT,
  `parca_id` int NOT NULL,
  `adet` int NOT NULL,
  `hareket_tipi` enum('giris','cikis') NOT NULL,
  `aciklama` varchar(255) DEFAULT NULL,
  `tarih` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `parca_id` (`parca_id`),
  CONSTRAINT `stok_hareketleri_ibfk_1` FOREIGN KEY (`parca_id`) REFERENCES `parcalar` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

SET FOREIGN_KEY_CHECKS=1;
