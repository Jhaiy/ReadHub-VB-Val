-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 17, 2023 at 06:15 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `readhub`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_in`
--

CREATE TABLE `admin_in` (
  `AdminIn_ID` int(11) NOT NULL,
  `Email` char(50) DEFAULT NULL,
  `Login_Time` char(10) DEFAULT NULL,
  `Login_Date` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin_in`
--

INSERT INTO `admin_in` (`AdminIn_ID`, `Email`, `Login_Time`, `Login_Date`) VALUES
(10000, 'flores.clarencekyle.manrique@gmail.com', '02:05:47', '0'),
(10001, 'flores.clarencekyle.manrique@gmail.com', '02:07:30', '1'),
(10002, 'flores.clarencekyle.manrique@gmail.com', '02:21:32', '1'),
(10003, 'flores.clarencekyle.manrique@gmail.com', '02:22:27', '1'),
(10004, 'flores.clarencekyle.manrique@gmail.com', '02:28:19', '1'),
(10005, 'flores.clarencekyle.manrique@gmail.com', '02:33:32', '14 Nov 202'),
(10006, 'flores.clarencekyle.manrique@gmail.com', '02:34:27', '14 Nov 2023'),
(10007, 'flores.clarencekyle.manrique@gmail.com', '02:40:22', '14 Nov 2023'),
(10008, 'flores.clarencekyle.manrique@gmail.com', '11:24:55', '13 Nov 2023'),
(10009, 'flores.clarencekyle.manrique@gmail.com', '11:28:19', '13 Nov 2023'),
(10010, 'flores.clarencekyle.manrique@gmail.com', '12:37:22', '14 Nov 2023'),
(10011, 'flores.clarencekyle.manrique@gmail.com', '12:40:28', '14 Nov 2023'),
(10012, 'flores.clarencekyle.manrique@gmail.com', '12:44:18', '14 Nov 2023'),
(10013, 'flores.clarencekyle.manrique@gmail.com', '12:45:39', '14 Nov 2023'),
(10014, 'flores.clarencekyle.manrique@gmail.com', '12:47:56', '14 Nov 2023'),
(10015, 'flores.clarencekyle.manrique@gmail.com', '12:50:51', '14 Nov 2023'),
(10016, 'flores.clarencekyle.manrique@gmail.com', '12:52:20', '14 Nov 2023'),
(10017, 'flores.clarencekyle.manrique@gmail.com', '12:52:59', '14 Nov 2023'),
(10018, 'flores.clarencekyle.manrique@gmail.com', '12:55:52', '14 Nov 2023'),
(10019, 'flores.clarencekyle.manrique@gmail.com', '01:01:08', '14 Nov 2023'),
(10020, 'flores.clarencekyle.manrique@gmail.com', '01:02:21', '14 Nov 2023'),
(10021, 'flores.clarencekyle.manrique@gmail.com', '01:10:22', '14 Nov 2023'),
(10022, 'flores.clarencekyle.manrique@gmail.com', '01:14:18', '14 Nov 2023'),
(10023, 'flores.clarencekyle.manrique@gmail.com', '01:16:14', '14 Nov 2023'),
(10024, 'flores.clarencekyle.manrique@gmail.com', '01:36:59', '14 Nov 2023'),
(10025, 'flores.clarencekyle.manrique@gmail.com', '01:38:12', '14 Nov 2023'),
(10026, 'flores.clarencekyle.manrique@gmail.com', '01:39:52', '14 Nov 2023'),
(10027, 'flores.clarencekyle.manrique@gmail.com', '01:41:50', '14 Nov 2023'),
(10028, 'flores.clarencekyle.manrique@gmail.com', '01:43:53', '14 Nov 2023'),
(10029, 'flores.clarencekyle.manrique@gmail.com', '01:44:10', '14 Nov 2023'),
(10030, 'flores.clarencekyle.manrique@gmail.com', '01:49:11', '14 Nov 2023'),
(10031, 'flores.clarencekyle.manrique@gmail.com', '01:57:20', '14 Nov 2023'),
(10032, 'flores.clarencekyle.manrique@gmail.com', '02:03:52', '14 Nov 2023'),
(10033, 'flores.clarencekyle.manrique@gmail.com', '02:09:42', '14 Nov 2023'),
(10034, 'flores.clarencekyle.manrique@gmail.com', '02:13:21', '14 Nov 2023'),
(10035, 'flores.clarencekyle.manrique@gmail.com', '07:54:00', '15 Nov 2023'),
(10036, 'flores.clarencekyle.manrique@gmail.com', '07:57:07', '15 Nov 2023'),
(10037, 'flores.clarencekyle.manrique@gmail.com', '08:07:09', '15 Nov 2023'),
(10038, 'flores.clarencekyle.manrique@gmail.com', '11:15:31', '15 Nov 2023'),
(10039, 'flores.clarencekyle.manrique@gmail.com', '11:21:41', '15 Nov 2023'),
(10040, 'flores.clarencekyle.manrique@gmail.com', '11:27:19', '15 Nov 2023'),
(10041, 'flores.clarencekyle.manrique@gmail.com', '11:42:01', '15 Nov 2023'),
(10042, 'flores.clarencekyle.manrique@gmail.com', '11:43:22', '15 Nov 2023'),
(10043, 'flores.clarencekyle.manrique@gmail.com', '11:48:21', '15 Nov 2023'),
(10044, 'flores.clarencekyle.manrique@gmail.com', '11:52:05', '15 Nov 2023'),
(10045, 'flores.clarencekyle.manrique@gmail.com', '11:55:20', '15 Nov 2023'),
(10046, 'flores.clarencekyle.manrique@gmail.com', '12:00:26', '15 Nov 2023'),
(10047, 'flores.clarencekyle.manrique@gmail.com', '01:45:42', '15 Nov 2023'),
(10048, 'flores.clarencekyle.manrique@gmail.com', '01:59:29', '15 Nov 2023'),
(10049, 'flores.clarencekyle.manrique@gmail.com', '02:11:51', '15 Nov 2023'),
(10050, 'flores.clarencekyle.manrique@gmail.com', '02:13:24', '15 Nov 2023'),
(10051, 'flores.clarencekyle.manrique@gmail.com', '02:14:34', '15 Nov 2023'),
(10052, 'flores.clarencekyle.manrique@gmail.com', '02:16:54', '15 Nov 2023'),
(10053, 'flores.clarencekyle.manrique@gmail.com', '02:17:20', '15 Nov 2023'),
(10054, 'flores.clarencekyle.manrique@gmail.com', '02:19:21', '15 Nov 2023'),
(10055, 'flores.clarencekyle.manrique@gmail.com', '02:30:30', '15 Nov 2023'),
(10056, 'flores.clarencekyle.manrique@gmail.com', '02:32:47', '15 Nov 2023'),
(10057, 'flores.clarencekyle.manrique@gmail.com', '02:34:45', '15 Nov 2023'),
(10058, 'flores.clarencekyle.manrique@gmail.com', '02:39:17', '15 Nov 2023'),
(10059, 'flores.clarencekyle.manrique@gmail.com', '02:41:47', '15 Nov 2023'),
(10060, 'flores.clarencekyle.manrique@gmail.com', '02:43:08', '15 Nov 2023'),
(10061, 'flores.clarencekyle.manrique@gmail.com', '02:54:36', '15 Nov 2023'),
(10062, 'flores.clarencekyle.manrique@gmail.com', '02:58:15', '15 Nov 2023'),
(10063, 'flores.clarencekyle.manrique@gmail.com', '02:59:42', '15 Nov 2023'),
(10064, 'flores.clarencekyle.manrique@gmail.com', '03:03:23', '15 Nov 2023'),
(10065, 'flores.clarencekyle.manrique@gmail.com', '03:06:07', '15 Nov 2023'),
(10066, 'flores.clarencekyle.manrique@gmail.com', '03:09:03', '15 Nov 2023'),
(10067, 'flores.clarencekyle.manrique@gmail.com', '03:13:29', '15 Nov 2023'),
(10068, 'flores.clarencekyle.manrique@gmail.com', '03:15:10', '15 Nov 2023'),
(10069, 'flores.clarencekyle.manrique@gmail.com', '03:16:12', '15 Nov 2023'),
(10070, 'flores.clarencekyle.manrique@gmail.com', '03:19:31', '15 Nov 2023'),
(10071, 'flores.clarencekyle.manrique@gmail.com', '03:27:14', '15 Nov 2023'),
(10072, 'flores.clarencekyle.manrique@gmail.com', '03:28:29', '15 Nov 2023'),
(10073, 'flores.clarencekyle.manrique@gmail.com', '03:29:10', '15 Nov 2023'),
(10074, 'flores.clarencekyle.manrique@gmail.com', '03:33:28', '15 Nov 2023'),
(10075, 'flores.clarencekyle.manrique@gmail.com', '03:38:39', '15 Nov 2023'),
(10076, 'flores.clarencekyle.manrique@gmail.com', '03:40:42', '15 Nov 2023'),
(10077, 'flores.clarencekyle.manrique@gmail.com', '03:46:30', '15 Nov 2023'),
(10078, 'flores.clarencekyle.manrique@gmail.com', '03:49:47', '15 Nov 2023'),
(10079, 'flores.clarencekyle.manrique@gmail.com', '03:50:53', '15 Nov 2023'),
(10080, 'flores.clarencekyle.manrique@gmail.com', '03:56:44', '15 Nov 2023'),
(10081, 'flores.clarencekyle.manrique@gmail.com', '03:59:01', '15 Nov 2023'),
(10082, 'flores.clarencekyle.manrique@gmail.com', '04:06:08', '15 Nov 2023'),
(10083, 'flores.clarencekyle.manrique@gmail.com', '05:56:29', '15 Nov 2023'),
(10084, 'flores.clarencekyle.manrique@gmail.com', '05:57:15', '15 Nov 2023'),
(10085, 'flores.clarencekyle.manrique@gmail.com', '05:57:44', '15 Nov 2023'),
(10086, 'flores.clarencekyle.manrique@gmail.com', '05:59:45', '15 Nov 2023'),
(10087, 'flores.clarencekyle.manrique@gmail.com', '06:01:50', '15 Nov 2023'),
(10088, 'flores.clarencekyle.manrique@gmail.com', '06:03:42', '15 Nov 2023'),
(10089, 'flores.clarencekyle.manrique@gmail.com', '08:41:54', '15 Nov 2023'),
(10090, 'flores.clarencekyle.manrique@gmail.com', '08:43:48', '15 Nov 2023'),
(10091, 'flores.clarencekyle.manrique@gmail.com', '08:49:45', '15 Nov 2023'),
(10092, 'flores.clarencekyle.manrique@gmail.com', '08:51:21', '15 Nov 2023'),
(10093, 'flores.clarencekyle.manrique@gmail.com', '08:52:58', '15 Nov 2023'),
(10094, 'flores.clarencekyle.manrique@gmail.com', '08:54:34', '15 Nov 2023'),
(10095, 'flores.clarencekyle.manrique@gmail.com', '08:58:12', '15 Nov 2023'),
(10096, 'flores.clarencekyle.manrique@gmail.com', '09:58:52', '15 Nov 2023'),
(10097, 'flores.clarencekyle.manrique@gmail.com', '10:01:47', '15 Nov 2023'),
(10098, 'flores.clarencekyle.manrique@gmail.com', '10:04:22', '15 Nov 2023'),
(10099, 'flores.clarencekyle.manrique@gmail.com', '10:06:08', '15 Nov 2023'),
(10100, 'flores.clarencekyle.manrique@gmail.com', '10:07:24', '15 Nov 2023'),
(10101, 'flores.clarencekyle.manrique@gmail.com', '10:08:51', '15 Nov 2023'),
(10102, 'flores.clarencekyle.manrique@gmail.com', '10:21:16', '15 Nov 2023'),
(10103, 'flores.clarencekyle.manrique@gmail.com', '10:27:22', '15 Nov 2023'),
(10104, 'flores.clarencekyle.manrique@gmail.com', '11:15:17', '15 Nov 2023'),
(10105, 'flores.clarencekyle.manrique@gmail.com', '11:16:59', '15 Nov 2023'),
(10106, 'flores.clarencekyle.manrique@gmail.com', '11:19:36', '15 Nov 2023'),
(10107, 'flores.clarencekyle.manrique@gmail.com', '11:20:57', '15 Nov 2023'),
(10108, 'flores.clarencekyle.manrique@gmail.com', '04:52:00', '16 Nov 2023'),
(10109, 'flores.clarencekyle.manrique@gmail.com', '04:56:10', '16 Nov 2023'),
(10110, 'flores.clarencekyle.manrique@gmail.com', '07:50:53', '16 Nov 2023');

-- --------------------------------------------------------

--
-- Table structure for table `admin_information`
--

CREATE TABLE `admin_information` (
  `Admin_ID` varchar(255) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Contact Number` int(255) NOT NULL,
  `Account_Created` date NOT NULL,
  `Status_ID` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin_information`
--

INSERT INTO `admin_information` (`Admin_ID`, `Fullname`, `Email`, `BorrowerType_ID`, `Address`, `Contact Number`, `Account_Created`, `Status_ID`, `password`) VALUES
('22-01', 'Flores, Clarence Kyle M.', 'flores.clarencekyle.manrique@gmail.com', 'BC_1', '#23 Kabilugan Street, Nitang Avenue, Brgy. Gulod, Novaliches, Quezon City', 2147483647, '2023-11-07', 'S_1', 'Kyle00');

-- --------------------------------------------------------

--
-- Table structure for table `admin_login`
--

CREATE TABLE `admin_login` (
  `AdminLogin_ID` varchar(255) NOT NULL,
  `Admin_ID` varchar(255) NOT NULL,
  `Login_Date` char(10) NOT NULL,
  `LogIn_Time` char(10) NOT NULL,
  `LogOut_Time` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `admin_out`
--

CREATE TABLE `admin_out` (
  `AdminOut_ID` int(11) NOT NULL,
  `Email` char(50) DEFAULT NULL,
  `Logout_Time` char(10) DEFAULT NULL,
  `Logout_Date` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin_out`
--

INSERT INTO `admin_out` (`AdminOut_ID`, `Email`, `Logout_Time`, `Logout_Date`) VALUES
(1000, '', '02:07:32', NULL),
(1001, 'flores.clarencekyle.manrique@gmail.com', '02:22:29', NULL),
(1002, 'flores.clarencekyle.manrique@gmail.com', '02:33:35', '14 Nov 202'),
(1003, 'flores.clarencekyle.manrique@gmail.com', '02:34:29', '14 Nov 2023'),
(1004, 'flores.clarencekyle.manrique@gmail.com', '02:40:28', '14 Nov 2023'),
(1005, 'flores.clarencekyle.manrique@gmail.com', '02:13:19', '15 Nov 2023'),
(1006, 'flores.clarencekyle.manrique@gmail.com', '02:16:49', '15 Nov 2023');

-- --------------------------------------------------------

--
-- Table structure for table `archive_books`
--

CREATE TABLE `archive_books` (
  `Archive_ID` int(7) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Category_ID` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Year_Published` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `archive_books`
--

INSERT INTO `archive_books` (`Archive_ID`, `Book_ID`, `Title`, `Author`, `Category_ID`, `Description`, `Year_Published`) VALUES
(3, 'BOOK_12', 'The Haunting of Ashburn House', 'Darcy Coates', 'CAT_2', 'A ghost story about Adrienne\nDelaney, a young woman who inherits an old mansion from her estranged aunt. She moves into\nthe house hoping for a fresh start, but soon discovers that the house has a dark history and a\nsinister presence that haunts its rooms.', 0000),
(4, 'BOOK_13', 'The Hound of the Baskervilles', 'Arthur Conan Doyle', 'CAT_2', 'The third novel featuring\nthe famous detective Sherlock Holmes and his sidekick Dr. Watson. The story involves a curse\nthat haunts the Baskerville family, who are said to be stalked by a monstrous hound on the moors\nof Dartmoor. Holmes and Watson are hire', 0000),
(5, 'BOOK_23', 'The Notebook', 'Nicholas Sparks', 'CAT_3', 'A contemporary romance novel that recounts\r\nthe enduring love story of Noah Calhoun and Allie Hamilton, who met as teenagers in the 1940s but were\r\nseparated by fate and social class. Years later, Noah, now an elderly man, reads from his notebook to\r\nAlli', 1996),
(6, 'BOOK_20', 'The Name of the Rose', 'Umberto Eco', 'CAT_2', 'A historical mystery novel set in a\r\nmedieval monastery in Italy in 1327. The story follows William of Baskerville, a Franciscan friar\r\nand former inquisitor, who arrives at the monastery to attend a theological debate.', 1980),
(7, 'BOOK_21', 'Pride and Prejudice', 'Jane Austen', 'CAT_3', 'The classic romance novel that tells the story\r\nof Elizabeth Bennet and Mr. Darcy, two people who initially dislike each other but gradually overcome\r\ntheir prejudices and fall in love. The novel is a witty and insightful commentary on the manners and\r\nmo', 0000),
(8, 'BOOK_19', 'In Cold Blood', 'Truman Capote', 'CAT_2', 'A groundbreaking work of nonfiction that tells\r\nthe true story of a brutal quadruple murder in Kansas in 1959. Capote spent six years researching\r\n\r\nand writing this book, which reconstructs the crime and its aftermath from multiple perspectives:\r\nthose o', 1966),
(9, 'BOOK_2', 'Frankenstein', 'Mary Shelly', 'CAT_1', 'The story of Victor Frankenstein, a young\nscientist who creates a grotesque creature in an unorthodox experiment. The creature, rejected\nby his creator and society, seeks revenge and causes havoc in his quest for companionship', 0000);

-- --------------------------------------------------------

--
-- Table structure for table `book_category`
--

CREATE TABLE `book_category` (
  `Category_ID` varchar(255) NOT NULL,
  `Category` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book_category`
--

INSERT INTO `book_category` (`Category_ID`, `Category`) VALUES
('Cat1', 'Horror'),
('Cat2', 'Mystery'),
('Cat3', 'Romance'),
('Cat4', 'Fantasy'),
('Cat5', 'History'),
('Cat6', 'Academics'),
('Cat7', 'Sci-Fi');

-- --------------------------------------------------------

--
-- Table structure for table `book_information`
--

CREATE TABLE `book_information` (
  `Book_ID` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Category_ID` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Year_Published` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book_information`
--

INSERT INTO `book_information` (`Book_ID`, `Title`, `Author`, `Category_ID`, `Description`, `Year_Published`) VALUES
('BOOK_1', 'Dracula', 'Bram Stoker', 'CAT_1', 'The classic vampire novel that inspired countless\nadaptations and influenced the horror genre for generations. The story follows the attempts of a\ngroup of friends to stop the evil Count Dracula from spreading his curse across England and the\nworld', 0000),
('BOOK_11', 'I Am Legend', 'Richard Matheson', 'CAT_1', 'A science fiction horror novel about Robert\nNeville, the last human survivor of a pandemic that turned most of humanity into vampire-like\ncreatures. He lives in an isolated house in Los Angeles, where he hunts down the vampires\n\nduring the day and barrica', 0000),
('BOOK_14', 'Murder on the Oriend Express', 'Agatha Christie', 'CAT_2', 'One of the most popular and\nacclaimed novels by the queen of mystery, Agatha Christie. The story follows Hercule Poirot, a\nBelgian detective, who is traveling on the Orient Express train from Istanbul to London. He is\nasked to solve a murder that occurred', 0000),
('BOOK_15', 'The Girl with the Dragon Tattoo', 'Stieg Larsson', 'CAT_2', 'The first novel in the\nMillennium series, a bestselling and award-winning crime thriller series from Sweden. The story\ncenters on Mikael Blomkvist, a disgraced journalist who is hired by a wealthy industrialist, Henrik\nVanger, to investigate the disappear', 0000),
('BOOK_16', 'The Da Vinci Code', 'Dan Brown', 'CAT_2', 'A controversial and sensational novel that\r\ncombines mystery, conspiracy, religion, and art. The story follows Robert Langdon, a Harvard\r\nprofessor of symbology, who is summoned to the Louvre Museum in Paris, where a curator has\r\nbeen murdered. He discove', 2003),
('BOOK_18', 'And Then There Were None', 'Agatha Christie', 'CAT_2', 'One of Christie’s most famous\r\nand acclaimed novels, often considered her masterpiece. The story involves ten strangers who\r\nare invited to an isolated island by a mysterious host. They soon discover that they have been\r\nlured there for a sinister purpose', 1939),
('BOOK_22', 'Gone with the Wind', 'Margaret Mitchell', 'CAT_3', 'A historical romance novel that follows\r\nthe life of Scarlett O’Hara, a spirited and ambitious Southern belle who survives the American Civil War\r\nand Reconstruction. She is torn between her love for the charming but unreliable Rhett Butler and her\r\nloyal', 1936),
('BOOK_24', 'Outlander', 'Diana Gabaldon', 'CAT_3', 'A historical fantasy romance novel that combines\r\ntime travel, adventure, and history. Claire Randall, a former combat nurse in 1945, is mysteriously\r\ntransported to 1743 Scotland, where she meets Jamie Fraser, a handsome and brave Highland warrior.\r\nShe ', 1991),
('BOOK_25', 'The Princess Bride', 'William Goldman', 'CAT_3', 'A fantasy romance novel that parodies\r\nthe conventions of fairy tales and swashbuckling stories. The novel frames itself as an abridged version\r\nof a longer work by a fictional author, S. Morgenstern, with commentary by Goldman himself. The story\r\nfollows', 1973),
('BOOK_26', 'The Time Traveler’s Wife', 'Audrey Neffenger', 'CAT_3', 'A science fiction romance novel\r\nthat explores the effects of time travel on a relationship. Henry DeTamble is a librarian who suffers from a\r\nrare genetic disorder that causes him to involuntarily travel through time, often leaving behind his wife\r\nClare', 2003),
('BOOK_27', 'The Fault in Our Stars', 'John Green', 'CAT_3', 'A young adult romance novel that deals\r\n\r\nwith the themes of life, death, and love in the face of terminal illness. Hazel Grace Lancaster is a sixteen-\r\nyear-old cancer patient who meets Augustus Waters, a charismatic and optimistic boy who lost his leg t', 2012),
('BOOK_28', 'Me Before You', 'Jojo Moyes', 'CAT_3', 'A contemporary romance novel that tackles the\r\ncontroversial issue of assisted suicide. Louisa Clark is a quirky and cheerful young woman who takes a\r\njob as a caregiver for Will Traynor, a wealthy and cynical former banker who became quadriplegic after\r\n', 2012),
('BOOK_29', 'Eleanor & Park', 'Rainbow Rowell', 'CAT_3', 'A young adult romance novel that captures\r\nthe joys and pains of first love in the 1980s. Eleanor Douglas is a misfit redhead who comes from a\r\ndysfunctional family. Park Sheridan is a half-Korean comic book fan who feels out of place in his mostly\r\nwhite', 2013),
('BOOK_3', 'The Shining', 'Stephen King', 'CAT_1', 'A psychological horror novel about a family that\nmoves into a haunted hotel, where the father, Jack Torrance, becomes possessed by the evil\nspirits and tries to kill his wife and son. The son, Danny, has psychic abilities that allow him to see\nthe horrors', 0000),
('BOOK_30', 'The Rosie Project', 'Graeme Simsion', 'CAT_3', 'A romantic comedy novel that features an\r\nunconventional protagonist. Don Tillman is a brilliant but socially inept genetics professor who has trouble\r\nfinding a suitable partner. He decides to create a detailed questionnaire to screen potential candidate', 2013),
('BOOK_3000', 'aa', 'aa', 'aa', 'aa', 2002),
('BOOK_31', 'The Night Circus', 'Erin Morgenstern', 'CAT_3', 'A fantasy romance novel that immerses the\r\nreader in a magical world of illusion and wonder. The novel revolves around Le Cirque des Rêves, a\r\nmysterious circus that only opens at night and features astonishing acts and attractions. Behind the\r\nscenes, ho', 2011),
('BOOK_32', 'The Kiss Quotient', 'Helen Hoang', 'CAT_3', 'A contemporary romance novel that features\r\na neurodiverse heroine and a diverse cast of characters. Stella Lane is a successful econometrician who\r\nhas Asperger’s syndrome, which makes her struggle with social interactions and intimacy.', 2018),
('BOOK_33', 'The Name of the Wind', 'Patrick Rothfuss', 'CAT_5', 'Follow the life of Kvothe, a gifted musician and magician, as he recounts his extraordinary\r\nadventures and magical education.', 2007),
('BOOK_34', 'The Lies of Locke Lamora', 'Scott Lynch', 'CAT_5', 'Join a group of cunning thieves known as the Gentlemen Bastards as they navigate the\r\ndangerous underworld of the city of Camorr.', 2006),
('BOOK_35', 'The Night Circus', 'Erin Morgenstern', 'CAT_5', 'Experience a magical competition between two young illusionists in a mysterious,\r\nenchanting circus that only appears at night.', 2011),
('BOOK_36', 'Mistborn: The Final Empire', 'Brandon Sanderson', 'CAT_5', 'Immerse yourself in a world where a young street thief discovers her unique magical abilities\r\nand joins a group of rebels to overthrow a dark lord.', 2006),
('BOOK_37', 'American Gods', 'Neil Gaiman', 'CAT_5', 'Shadow Moon, a recently released ex-convict, becomes entangled in the world of ancient\r\ngods and modern myths in this dark and imaginative tale.', 2001),
('BOOK_38', 'The Way of Kings', 'Brandon Sanderson', 'CAT_5', 'Enter the sprawling, epic world of Roshar, where powerful magic, political intrigue, and\r\ndiverse characters collide in this high-fantasy series.', 2010),
('BOOK_39', 'The Golden Compass', 'Philip Pullman', 'CAT_5', 'Join Lyra Belacqua on her journey to the Arctic to rescue kidnapped children in a parallel\r\nuniverse filled with magic and daemons.', 1995),
('BOOK_4', 'The Haunting of Hill House', 'Shirley Jackson', 'CAT_1', 'A gothic horror novel about four\npeople who stay at a notorious mansion, hoping to find evidence of the supernatural. They soon\ndiscover that the house has a mind of its own and is bent on terrorizing them', 0000),
('BOOK_40', 'The Black Prism', 'Brent Weeks', 'CAT_5', 'Explore a world where magic is harnessed through light and color, and follow the story of a\r\npowerful drafter named Gavin Guile.', 2010),
('BOOK_41', 'A Wizard of Earthsea', 'Ursula K. Le Guin', 'CAT_5', 'Follow the coming-of-age journey of Ged, a young wizard, as he battles dark forces and\r\nseeks balance in the archipelago of Earthsea.', 1968),
('BOOK_42', 'The Final Empire', 'Michael J. Sullivan', 'CAT_5', 'Join a skilled thief and a skilled warrior as they plan to overthrow an oppressive ruler in a\r\nworld where magic is rare and powerful.', 2008),
('BOOK_43', 'Assassin\'s Apprentice', 'Robin Hobb', 'CAT_5', 'Step into the world of Fitz, a royal bastard who becomes the apprentice of a royal assassin,\r\nnavigating court politics and a destiny intertwined with the kingdom.', 1995),
('BOOK_44', 'The Magicians', 'Lev Grossman', 'CAT_5', 'Follow the story of Quentin Coldwater as he discovers Brakebills, a secret college for\r\nmagicians, and explores a darker and more dangerous world of magic.', 2009),
('BOOK_45', 'A People\'s History of the United States', 'Howard Zinn', 'CAT_5', 'This influential work offers a different perspective on U.S. history, focusing on the\r\nexperiences of ordinary people and marginalized groups throughout the nation\'s history.', 1980),
('BOOK_46', 'The Diary of a Young Girl', 'Anne Frank', 'CAT_5', 'Anne Frank\'s diary, written during the Holocaust, provides a poignant and firsthand account\r\nof life in hiding during World War II.', 1947),
('BOOK_47', 'The Wright Brothers', 'David McCullough', 'CAT_5', 'Delve into the story of Wilbur and Orville Wright, who achieved the first powered, controlled\r\nflight, and changed the course of aviation history.', 2015),
('BOOK_48', 'The Guns of August', 'Barbara W. Tuchman', 'CAT_5', 'This book offers a detailed account of the events leading up to World War I and the first\r\nmonth of the war, examining the political and military strategies.', 1962),
('BOOK_49', 'SPQR: A History of Ancient Rome', 'Mary Beard', 'CAT_5', 'Explore the rise and fall of the Roman Empire, shedding light on the everyday lives of its\r\ncitizens and the political landscape.', 2015),
('BOOK_5', 'The Exorcist', 'William Peter Blatty', 'CAT_1', 'A terrifying novel based on a true case of\ndemonic possession. A young girl, Regan, starts to exhibit strange and violent behavior, and her\nmother seeks the help of two priests to perform an exorcism. The novel explores the themes of\nfaith, evil, and free', 0000),
('BOOK_50', 'The Silk Roads: A New History of the World', 'Peter Frankopan', 'CAT_5', 'Discover the central role of the Silk Roads in shaping world history, connecting civilizations,\r\nand facilitating the exchange of goods and ideas.', 2015),
('BOOK_51', 'Team of Rivals: The Political Genius of Abraham Lincoln', 'Doris Kearns Goodwin', 'CAT_5', 'Explore the leadership and political acumen of Abraham Lincoln as he navigated the\r\nchallenges of the American Civil War.', 2005),
('BOOK_52', 'The Rise and Fall of the Third Reich', 'William L. Shirer', 'CAT_5', 'This comprehensive work offers a detailed history of Nazi Germany and its role in World War\r\nII, providing insight into Hitler\'s regime.', 1960),
('BOOK_53', '1776', 'David McCullough', 'CAT_5', 'Follow the events of the pivotal year 1776 during the American Revolutionary War,\r\nhighlighting the struggles and triumphs of the Continental Army.', 2005),
('BOOK_54', 'Guns, Germs, and Steel: The Fates of Human Societies', 'Jared Diamond', 'CAT_5', 'Explore the influence of geography, agriculture, and technology in shaping the course of\r\nhuman history across different continents.', 1997),
('BOOK_55', 'The Plantagenets: The Warrior Kings and Queens Who Made England', 'Dan Jones', 'CAT_5', 'Trace the history of the Plantagenet dynasty in England, from the reign of King Henry II to\r\nthe Wars of the Roses.', 2012),
('BOOK_56', 'The Swerve: How the World Became Modern', 'Stephen Greenblatt', 'CAT_5', 'Discover the story of a 15th-century manuscript hunter who uncovered an ancient Roman\r\npoem and how it influenced the Renaissance.', 2011),
('BOOK_6', 'The Silence of Lambs', 'Thomas Harris', 'CAT_1', 'A thriller novel about a young FBI\ntrainee, Clarice Starling, who is assigned to interview a notorious serial killer, Hannibal Lecter, in\norder to catch another killer on the loose. Lecter, a brilliant and manipulative psychiatrist, plays a\ndeadly game of', 0000),
('BOOK_7', 'World War Z', 'Max Brooks', 'CAT_1', 'A zombie apocalypse novel that presents a global\nperspective on the outbreak and its aftermath. The novel is written as a series of interviews with\nsurvivors from different countries and backgrounds, who share their stories of horror, heroism,\nand hope', 0000),
('BOOK_8', 'Bird Box', 'Josh Malerman', 'CAT_1', 'A post-apocalyptic novel about a woman, Malorie,\nwho tries to protect her two children from a mysterious force that drives people insane if they see\nit. She and her children must navigate a dangerous world blindfolded, relying on their other\nsenses and th', 0000),
('BOOK_9', 'The Girl with All the Gifts', 'M.R. Carey', 'CAT_1', 'A dystopian novel about a young girl,\nMelanie, who is infected with a fungus that turns people into flesh-eating zombies. She is kept in\na military base with other children like her, where she is studied by scientists and taught by\nteachers. She is unawar', 0000);

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_books_employee`
--

CREATE TABLE `borrowed_books_employee` (
  `BorrowedBooks_ID` int(11) NOT NULL,
  `User_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Date_Borrowed` char(20) DEFAULT NULL,
  `Return_Date` char(20) DEFAULT NULL,
  `Fine_Status_ID` varchar(255) DEFAULT NULL,
  `Fine_Amount` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_books_student`
--

CREATE TABLE `borrowed_books_student` (
  `BorrowedBooks_ID` int(11) NOT NULL,
  `User_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Date_Borrowed` char(20) DEFAULT NULL,
  `Return_Date` char(20) DEFAULT NULL,
  `Fine_Status_ID` varchar(255) DEFAULT NULL,
  `Fine_Amount` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `borrower_category`
--

CREATE TABLE `borrower_category` (
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Borrower_Type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `borrower_category`
--

INSERT INTO `borrower_category` (`BorrowerType_ID`, `Borrower_Type`) VALUES
('BC_1', 'Admin'),
('BC_2', 'Faculty Member'),
('BC_3', 'Student');

-- --------------------------------------------------------

--
-- Table structure for table `borrowing_history`
--

CREATE TABLE `borrowing_history` (
  `BorrowingHistory_ID` varchar(255) NOT NULL,
  `User_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Date_Borrowed` date NOT NULL,
  `Return_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `campus`
--

CREATE TABLE `campus` (
  `Campus_ID` varchar(255) NOT NULL,
  `Campus` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `campus`
--

INSERT INTO `campus` (`Campus_ID`, `Campus`) VALUES
('C_1', 'SB'),
('C_2', 'SF'),
('C_3', 'Batasan');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `Department_ID` varchar(255) NOT NULL,
  `Department` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`Department_ID`, `Department`) VALUES
('D_1', 'IT'),
('D_2', 'IS'),
('D_3', 'CS'),
('D_4', 'Accountancy'),
('D_5', 'MA'),
('D_6', 'Entrepreneurship'),
('D_7', 'IE'),
('D_8', 'ECE'),
('D_9', 'ECEd');

-- --------------------------------------------------------

--
-- Table structure for table `employee_information`
--

CREATE TABLE `employee_information` (
  `User_ID` varchar(255) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Contact Number` int(255) NOT NULL,
  `Department_ID` varchar(255) NOT NULL,
  `Account_Created` datetime(6) DEFAULT NULL,
  `Status_ID` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee_information`
--

INSERT INTO `employee_information` (`User_ID`, `Fullname`, `Email`, `BorrowerType_ID`, `Address`, `Contact Number`, `Department_ID`, `Account_Created`, `Status_ID`, `password`) VALUES
('22-01', 'Geo', 'Geo@gmail.com', 'BC_2', 'QCU', 2147483647, 'D_1', '2023-11-15 00:00:00.000000', 'S_2', 'Oeg00');

-- --------------------------------------------------------

--
-- Table structure for table `favorites`
--

CREATE TABLE `favorites` (
  `Favorite_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Date_Added` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `fine_status`
--

CREATE TABLE `fine_status` (
  `Fine_Status_ID` varchar(255) NOT NULL,
  `Fine_status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fine_status`
--

INSERT INTO `fine_status` (`Fine_Status_ID`, `Fine_status`) VALUES
('F_1', 'Paid'),
('F_2', 'Unpaid'),
('F_3', 'Pending'),
('F_4', 'Partial payment');

-- --------------------------------------------------------

--
-- Table structure for table `library_eligibility_employee`
--

CREATE TABLE `library_eligibility_employee` (
  `User_ID` varchar(255) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Contact Number` int(255) NOT NULL,
  `Department_ID` varchar(255) NOT NULL,
  `Account_Created` date NOT NULL,
  `Status_ID` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `library_eligibility_employee`
--

INSERT INTO `library_eligibility_employee` (`User_ID`, `Fullname`, `Email`, `BorrowerType_ID`, `Address`, `Contact Number`, `Department_ID`, `Account_Created`, `Status_ID`, `password`) VALUES
('22-0419', 'Princes Daneille N. Caccam', 'princesdaneille@gmail.com', 'BC_2', '06 Marcopolo Comp. Brgy Sta. Lucia Nova Q.C.', 2147483647, 'D_2', '2023-11-07', 'S_1', NULL),
('22-523', 'Arabela Buce Capongcol', 'capongcol.arabela.buce@gmail.com', 'BC_3', '943 san Pascual street commonwealth quezon city', 2147483647, 'D_6', '2023-11-07', 'S_1', NULL),
('23-001', 'Sarah Grace', 'SarahGrace@gmail.com', 'BC_2', 'BGC', 2147483647, 'D_4', '2023-11-07', 'S_1', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `library_eligibility_student`
--

CREATE TABLE `library_eligibility_student` (
  `User_ID` varchar(255) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Contact Number` int(255) NOT NULL,
  `Program_ID` varchar(255) NOT NULL,
  `Campus_ID` varchar(255) NOT NULL,
  `Status_ID` varchar(255) NOT NULL,
  `Account_Created` date NOT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `library_eligibility_student`
--

INSERT INTO `library_eligibility_student` (`User_ID`, `Fullname`, `Email`, `BorrowerType_ID`, `Address`, `Contact Number`, `Program_ID`, `Campus_ID`, `Status_ID`, `Account_Created`, `password`) VALUES
('22-0035', 'Rhaine Hdart Coldovero', 'coldoverorhainehdart@gmail.com', 'BC_3', '1454 Purok 5-A Waterhole Litex rd. Brgy. Commonwealth Quezon City', 2147483647, 'P_1', 'C_1', 'S_1', '2023-11-05', NULL),
('22-0204', 'John Lloyd Gierza Gilo', 'gilojohnlloydgierza@gmail.com', 'BC_3', 'Pascualer Ville San Bartolome QC', 2147483647, 'P_1', 'C_1', 'S_1', '2023-11-07', NULL),
('22-2816', 'Chris Gian Quiming Cabico', 'cabico.chrisgia.quiming@gmail.com', 'BC_3', 'Brgy. San Agustin Novaliches Quezon City', 2147483647, 'P_1', 'C_1', 'S_1', '2023-11-07', NULL),
('22-2840', 'Joaquin Carlos V. Henson', 'joaquinhenson4@gmail.com', 'BC_3', 'B-65 L-32 Haring Constantino St. Brgy.Greater Lagro Novaliches Q.C', 2147483647, 'P_1', 'C_1', 'S_1', '2023-11-07', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `overdue`
--

CREATE TABLE `overdue` (
  `Overdue_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Borrower_ID` varchar(255) NOT NULL,
  `Return_Date` date NOT NULL,
  `Fine_ID` varchar(255) NOT NULL,
  `Fine_Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `programs`
--

CREATE TABLE `programs` (
  `Program_ID` varchar(255) NOT NULL,
  `Program` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `programs`
--

INSERT INTO `programs` (`Program_ID`, `Program`) VALUES
('P_1', 'BSIT'),
('P_2', 'BSIS'),
('P_3', 'BSCS'),
('P_4', 'BSA'),
('P_5', 'BSMA'),
('P_6', 'BSEntrep'),
('P_7', 'BSIE'),
('P_8', 'BSECE'),
('P_9', 'BSCed');

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

CREATE TABLE `status` (
  `Status_ID` varchar(255) NOT NULL,
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `status`
--

INSERT INTO `status` (`Status_ID`, `Status`) VALUES
('S_1', 'Active'),
('S_2', 'Inactive'),
('S_3', 'Suspended'),
('S_4', 'Graduated'),
('S_5', 'Transferred');

-- --------------------------------------------------------

--
-- Table structure for table `student_information`
--

CREATE TABLE `student_information` (
  `User_ID` varchar(255) NOT NULL,
  `Fullname` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `BorrowerType_ID` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Contact Number` int(255) NOT NULL,
  `Program_ID` varchar(255) DEFAULT NULL,
  `Campus_ID` varchar(255) DEFAULT NULL,
  `Status_ID` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `Account_Created` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student_information`
--

INSERT INTO `student_information` (`User_ID`, `Fullname`, `Email`, `BorrowerType_ID`, `Address`, `Contact Number`, `Program_ID`, `Campus_ID`, `Status_ID`, `password`, `Account_Created`) VALUES
('22-0000', 'Rhaine', 'coldoverorhainehdart@gmail.com', 'BC_3', '1454 Purok 5-A Waterhole Litex rd. Brgy Commonwealth', 2147483647, 'P_1', 'C_1', 'S_1', 'Rhaine13', '2023-11-15 00:00:00.000000'),
('asdasd', 'Rene', 'Rene@gmail.com', 'BC_2', 'BGC', 2147483647, 'P_2', 'C_1', 'S_2', 'Rene10', '2023-11-15 00:00:00.000000');

-- --------------------------------------------------------

--
-- Table structure for table `trending_books`
--

CREATE TABLE `trending_books` (
  `TrendingBooks_ID` varchar(255) NOT NULL,
  `Book_ID` varchar(255) NOT NULL,
  `Trend_Date` date NOT NULL,
  `Borrow_Count` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_in`
--
ALTER TABLE `admin_in`
  ADD PRIMARY KEY (`AdminIn_ID`);

--
-- Indexes for table `admin_information`
--
ALTER TABLE `admin_information`
  ADD PRIMARY KEY (`Admin_ID`),
  ADD KEY `BorrowerType_ID` (`BorrowerType_ID`),
  ADD KEY `Status_ID` (`Status_ID`);

--
-- Indexes for table `admin_login`
--
ALTER TABLE `admin_login`
  ADD PRIMARY KEY (`AdminLogin_ID`),
  ADD KEY `Admin_ID` (`Admin_ID`);

--
-- Indexes for table `admin_out`
--
ALTER TABLE `admin_out`
  ADD PRIMARY KEY (`AdminOut_ID`);

--
-- Indexes for table `archive_books`
--
ALTER TABLE `archive_books`
  ADD PRIMARY KEY (`Archive_ID`);

--
-- Indexes for table `book_category`
--
ALTER TABLE `book_category`
  ADD PRIMARY KEY (`Category_ID`);

--
-- Indexes for table `book_information`
--
ALTER TABLE `book_information`
  ADD PRIMARY KEY (`Book_ID`),
  ADD KEY `Category_ID` (`Category_ID`);

--
-- Indexes for table `borrowed_books_employee`
--
ALTER TABLE `borrowed_books_employee`
  ADD PRIMARY KEY (`BorrowedBooks_ID`),
  ADD KEY `Fine_Status_ID_Fac` (`Fine_Status_ID`);

--
-- Indexes for table `borrowed_books_student`
--
ALTER TABLE `borrowed_books_student`
  ADD PRIMARY KEY (`BorrowedBooks_ID`),
  ADD KEY `Fine_Status_ID_Stud` (`Fine_Status_ID`);

--
-- Indexes for table `borrower_category`
--
ALTER TABLE `borrower_category`
  ADD PRIMARY KEY (`BorrowerType_ID`);

--
-- Indexes for table `borrowing_history`
--
ALTER TABLE `borrowing_history`
  ADD PRIMARY KEY (`BorrowingHistory_ID`),
  ADD KEY `User_IDEMP` (`User_ID`),
  ADD KEY `Book_IDHISTORY` (`Book_ID`);

--
-- Indexes for table `campus`
--
ALTER TABLE `campus`
  ADD PRIMARY KEY (`Campus_ID`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`Department_ID`);

--
-- Indexes for table `employee_information`
--
ALTER TABLE `employee_information`
  ADD PRIMARY KEY (`User_ID`),
  ADD KEY `BorrowerType_IDEMP` (`BorrowerType_ID`),
  ADD KEY `DEPARTMENT_ID` (`Department_ID`),
  ADD KEY `Status_IDEMP` (`Status_ID`);

--
-- Indexes for table `favorites`
--
ALTER TABLE `favorites`
  ADD PRIMARY KEY (`Favorite_ID`),
  ADD KEY `Book_IDFAV` (`Book_ID`);

--
-- Indexes for table `fine_status`
--
ALTER TABLE `fine_status`
  ADD PRIMARY KEY (`Fine_Status_ID`);

--
-- Indexes for table `library_eligibility_employee`
--
ALTER TABLE `library_eligibility_employee`
  ADD PRIMARY KEY (`User_ID`),
  ADD KEY `fk_library_employee_borrowertype` (`BorrowerType_ID`),
  ADD KEY `fk_library_employee_department` (`Department_ID`),
  ADD KEY `fk_library_employee_status` (`Status_ID`);

--
-- Indexes for table `library_eligibility_student`
--
ALTER TABLE `library_eligibility_student`
  ADD PRIMARY KEY (`User_ID`),
  ADD KEY `BorrowerType_IDELI` (`BorrowerType_ID`),
  ADD KEY `Program_ID` (`Program_ID`),
  ADD KEY `Campus_ID` (`Campus_ID`),
  ADD KEY `Status_IDELI` (`Status_ID`);

--
-- Indexes for table `overdue`
--
ALTER TABLE `overdue`
  ADD PRIMARY KEY (`Overdue_ID`),
  ADD KEY `Book_IDOVE` (`Book_ID`),
  ADD KEY `Borrower_IDOVE` (`Borrower_ID`),
  ADD KEY `FINE_ID` (`Fine_ID`);

--
-- Indexes for table `programs`
--
ALTER TABLE `programs`
  ADD PRIMARY KEY (`Program_ID`);

--
-- Indexes for table `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`Status_ID`);

--
-- Indexes for table `student_information`
--
ALTER TABLE `student_information`
  ADD PRIMARY KEY (`User_ID`),
  ADD KEY `BorrowerType_IDSTU` (`BorrowerType_ID`),
  ADD KEY `Program_IDSTU` (`Program_ID`),
  ADD KEY `Campus_IDSTU` (`Campus_ID`),
  ADD KEY `Status_IDSTU` (`Status_ID`);

--
-- Indexes for table `trending_books`
--
ALTER TABLE `trending_books`
  ADD PRIMARY KEY (`TrendingBooks_ID`),
  ADD KEY `Book_IDTRE` (`Book_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_in`
--
ALTER TABLE `admin_in`
  MODIFY `AdminIn_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10111;

--
-- AUTO_INCREMENT for table `admin_out`
--
ALTER TABLE `admin_out`
  MODIFY `AdminOut_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1007;

--
-- AUTO_INCREMENT for table `archive_books`
--
ALTER TABLE `archive_books`
  MODIFY `Archive_ID` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `borrowed_books_employee`
--
ALTER TABLE `borrowed_books_employee`
  MODIFY `BorrowedBooks_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100100;

--
-- AUTO_INCREMENT for table `borrowed_books_student`
--
ALTER TABLE `borrowed_books_student`
  MODIFY `BorrowedBooks_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10010;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin_information`
--
ALTER TABLE `admin_information`
  ADD CONSTRAINT `BorrowerType_ID` FOREIGN KEY (`BorrowerType_ID`) REFERENCES `borrower_category` (`BorrowerType_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Status_ID` FOREIGN KEY (`Status_ID`) REFERENCES `status` (`Status_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `admin_login`
--
ALTER TABLE `admin_login`
  ADD CONSTRAINT `Admin_ID` FOREIGN KEY (`Admin_ID`) REFERENCES `admin_information` (`Admin_ID`);

--
-- Constraints for table `borrowed_books_employee`
--
ALTER TABLE `borrowed_books_employee`
  ADD CONSTRAINT `Fine_Status_ID_Fac` FOREIGN KEY (`Fine_Status_ID`) REFERENCES `fine_status` (`Fine_Status_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `borrowed_books_student`
--
ALTER TABLE `borrowed_books_student`
  ADD CONSTRAINT `Fine_Status_ID_Stud` FOREIGN KEY (`Fine_Status_ID`) REFERENCES `fine_status` (`Fine_Status_ID`);

--
-- Constraints for table `borrowing_history`
--
ALTER TABLE `borrowing_history`
  ADD CONSTRAINT `Book_IDHISTORY` FOREIGN KEY (`Book_ID`) REFERENCES `book_information` (`Book_ID`),
  ADD CONSTRAINT `User_IDEMP` FOREIGN KEY (`User_ID`) REFERENCES `employee_information` (`User_ID`),
  ADD CONSTRAINT `User_IDSTUD` FOREIGN KEY (`User_ID`) REFERENCES `student_information` (`User_ID`);

--
-- Constraints for table `employee_information`
--
ALTER TABLE `employee_information`
  ADD CONSTRAINT `BorrowerType_IDEMP` FOREIGN KEY (`BorrowerType_ID`) REFERENCES `borrower_category` (`BorrowerType_ID`),
  ADD CONSTRAINT `DEPARTMENT_ID` FOREIGN KEY (`Department_ID`) REFERENCES `departments` (`Department_ID`),
  ADD CONSTRAINT `Status_IDEMP` FOREIGN KEY (`Status_ID`) REFERENCES `status` (`Status_ID`);

--
-- Constraints for table `favorites`
--
ALTER TABLE `favorites`
  ADD CONSTRAINT `Book_IDFAV` FOREIGN KEY (`Book_ID`) REFERENCES `book_information` (`Book_ID`);

--
-- Constraints for table `library_eligibility_employee`
--
ALTER TABLE `library_eligibility_employee`
  ADD CONSTRAINT `fk_library_employee_borrowertype` FOREIGN KEY (`BorrowerType_ID`) REFERENCES `borrower_category` (`BorrowerType_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_library_employee_department` FOREIGN KEY (`Department_ID`) REFERENCES `departments` (`Department_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_library_employee_status` FOREIGN KEY (`Status_ID`) REFERENCES `status` (`Status_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `library_eligibility_student`
--
ALTER TABLE `library_eligibility_student`
  ADD CONSTRAINT `BorrowerType_IDELI` FOREIGN KEY (`BorrowerType_ID`) REFERENCES `borrower_category` (`BorrowerType_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Campus_ID` FOREIGN KEY (`Campus_ID`) REFERENCES `campus` (`Campus_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Program_ID` FOREIGN KEY (`Program_ID`) REFERENCES `programs` (`Program_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Status_IDELI` FOREIGN KEY (`Status_ID`) REFERENCES `status` (`Status_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `overdue`
--
ALTER TABLE `overdue`
  ADD CONSTRAINT `Book_IDOVE` FOREIGN KEY (`Book_ID`) REFERENCES `book_information` (`Book_ID`),
  ADD CONSTRAINT `Borrower_IDOVE` FOREIGN KEY (`Borrower_ID`) REFERENCES `book_information` (`Book_ID`),
  ADD CONSTRAINT `FINE_ID` FOREIGN KEY (`Fine_ID`) REFERENCES `fine_status` (`Fine_Status_ID`);

--
-- Constraints for table `student_information`
--
ALTER TABLE `student_information`
  ADD CONSTRAINT `Campus_IDSTU` FOREIGN KEY (`Campus_ID`) REFERENCES `campus` (`Campus_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Program_IDSTU` FOREIGN KEY (`Program_ID`) REFERENCES `programs` (`Program_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Status_IDSTU` FOREIGN KEY (`Status_ID`) REFERENCES `status` (`Status_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_borrower_type` FOREIGN KEY (`BorrowerType_ID`) REFERENCES `borrower_category` (`BorrowerType_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `trending_books`
--
ALTER TABLE `trending_books`
  ADD CONSTRAINT `Book_IDTRE` FOREIGN KEY (`Book_ID`) REFERENCES `book_information` (`Book_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
