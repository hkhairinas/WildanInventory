-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Des 2019 pada 16.56
-- Versi server: 10.4.6-MariaDB-log
-- Versi PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wildaninventory`
--

DELIMITER $$
--
-- Prosedur
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddData` (`_ID` VARCHAR(45), `_Barcode` VARCHAR(45), `_Name` VARCHAR(45), `_Category` INT, `_CashierPrice` INT, `_MinStock` INT, `_Uom` VARCHAR(45), `_BuyPrice` INT, `_SellPrice` INT, `_Disc` INT, `_User` VARCHAR(45))  BEGIN
		INSERT INTO product (`pid`, `pbarcode`, `pname`, `puom`, `pminstock`, `psell`, `pbuy`, `pdisc`, `pprice`, `cid`, `uid`)
        values (
			pid = _ID,
			pbarcode = _Barcode,
            cid = _Category,
            pname = _Name,
            puom = _Uom,
            pminstock = _MinStock,
            pprice = _CashierPrice,
            psell = _SellPrice,
            pbuy = _BuyPrice,
            pdisc = _Disc,
            uid = _User);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteByID` (`_ProductID` VARCHAR(45), `_Barcode` INT)  BEGIN
	DELETE FROM product
    WHERE pid = _ProductID AND pbarcode = _Barcode;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `EditData` (`_ID` VARCHAR(45), `_Barcode` VARCHAR(45), `_Name` VARCHAR(45), `_Category` INT, `_CashierPrice` INT, `_MinStock` INT, `_Uom` VARCHAR(45), `_BuyPrice` INT, `_SellPrice` INT)  BEGIN
		UPDATE product
        SET
			pbarcode = _Barcode,
            cid = _Category,
            pname = _Name,
            puom = _Uom,
            pminstock = _MinStock,
            pprice = _CashierPrice,
            psell = _SellPrice,
            pbuy = _BuyPrice
		WHERE pid = _ID AND pbarcode = _Barcode;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProductView` (`_OFF` INT(10))  BEGIN
	SELECT 
    pid AS 'ID',
    pbarcode AS 'Barcode', 
    cid AS 'Kategori',
    pname AS 'Nama Produk', 
    puom AS 'Qty', pminstock AS 'Stok Minimal', 
    pbuy AS 'Harga Beli', psell AS 'Harga Jual', 
    pprice AS 'Harga Kasir' 
    FROM product 
    ORDER BY pname 
    ASC
    LIMIT 10
    OFFSET _OFF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchByValue` (`_SearchValue` VARCHAR(45))  BEGIN
	SELECT pid AS 'ID', 
    pbarcode AS 'Barcode', 
    cid AS 'Kategori',
    pname AS 'Nama Produk', 
    puom AS 'Qty', pminstock AS 'Stok Minimal', 
    pbuy AS 'Harga Beli', psell AS 'Harga Jual', 
    pprice AS 'Harga Kasir' 
    FROM product
    WHERE pbarcode LIKE CONCAT('%',_SearchValue,'%') || pname LIKE CONCAT('%',_SearchValue,'%'); 
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchFix` (`_SearchFix` VARCHAR(45))  BEGIN
	SELECT pbarcode,
    pname, 
    pprice
    FROM product
    WHERE pbarcode = _SearchFix || pname = _SearchFix; 
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `category`
--

CREATE TABLE `category` (
  `cid` int(11) NOT NULL,
  `cname` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `category`
--

INSERT INTO `category` (`cid`, `cname`) VALUES
(109, 'Minuman'),
(110, 'Makanan'),
(111, 'Susu'),
(112, 'Sabun'),
(117, 'Rokok');

-- --------------------------------------------------------

--
-- Struktur dari tabel `product`
--

CREATE TABLE `product` (
  `pid` varchar(20) NOT NULL,
  `pbarcode` varchar(20) NOT NULL,
  `pname` varchar(30) NOT NULL,
  `puom` varchar(10) NOT NULL,
  `pminstock` int(11) NOT NULL,
  `psell` int(11) NOT NULL,
  `pbuy` int(11) NOT NULL,
  `pdisc` int(11) NOT NULL,
  `pprice` int(11) NOT NULL,
  `cid` int(11) NOT NULL,
  `uid` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaction`
--

CREATE TABLE `transaction` (
  `tid` varchar(12) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaction`
--

INSERT INTO `transaction` (`tid`, `date`, `total`) VALUES
('201912161001', '2019-12-16 10:53:31', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `uid` varchar(10) NOT NULL,
  `uname` varchar(16) NOT NULL,
  `upass` varchar(45) NOT NULL,
  `access` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`uid`, `uname`, `upass`, `access`) VALUES
('ID101', 'admin', '21232f297a57a5a743894a0e4a801fc3', 1),
('ID102', 'kasir', 'c7911af3adbd12a035b289556d96470a', 2);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`cid`);

--
-- Indeks untuk tabel `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`pid`,`pbarcode`),
  ADD KEY `uid` (`uid`),
  ADD KEY `cid` (`cid`);

--
-- Indeks untuk tabel `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`tid`);

--
-- Indeks untuk tabel `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`uid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
