-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Фев 24 2023 г., 21:00
-- Версия сервера: 8.0.30
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `reservationhotelsdatabase`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Hotel`
--

CREATE TABLE `Hotel` (
  `ID` int NOT NULL,
  `Title` varchar(100) DEFAULT NULL,
  `CountOfStars` int DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Hotel`
--

INSERT INTO `Hotel` (`ID`, `Title`, `CountOfStars`, `Address`) VALUES
(1, 'Элеон', 3, 'улица Кузнецкая д.18'),
(2, 'Ветка', 2, 'Площадь Победы 122');

-- --------------------------------------------------------

--
-- Структура таблицы `Rservation`
--

CREATE TABLE `Rservation` (
  `ID` int NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Surname` varchar(100) DEFAULT NULL,
  `Patronymic` varchar(100) DEFAULT NULL,
  `NumberPhone` varchar(100) DEFAULT NULL,
  `DateOfReservation` varchar(100) DEFAULT NULL,
  `HotelID` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Rservation`
--

INSERT INTO `Rservation` (`ID`, `Name`, `Surname`, `Patronymic`, `NumberPhone`, `DateOfReservation`, `HotelID`) VALUES
(1, 'Сергей', 'Пак', 'Радионович ', '88005553535', '12.12.2023', 2),
(2, ' Голден', 'Даун', 'Кринжович', '88003333535', '01.12.2022', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Hotel`
--
ALTER TABLE `Hotel`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `Rservation`
--
ALTER TABLE `Rservation`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `HotelID` (`HotelID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Hotel`
--
ALTER TABLE `Hotel`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Rservation`
--
ALTER TABLE `Rservation`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Rservation`
--
ALTER TABLE `Rservation`
  ADD CONSTRAINT `rservation_ibfk_1` FOREIGN KEY (`HotelID`) REFERENCES `Hotel` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
