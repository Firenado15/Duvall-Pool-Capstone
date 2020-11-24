-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbCapstone; -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID ( 'TCustomerPayments' )			IS NOT NULL DROP TABLE TCustomerPayments
IF OBJECT_ID( 'TCreditCards' )					IS NOT NULL DROP TABLE TCreditCards
IF OBJECT_ID( 'TInvoices' )						IS NOT NULL DROP TABLE TInvoices
IF OBJECT_ID( 'TJobServices' )					IS NOT NULL DROP TABLE TJobServices
IF OBJECT_ID( 'TJobEmployees' )					IS NOT NULL DROP TABLE TJobEmployees
IF OBJECT_ID( 'TJobParts' )						IS NOT NULL DROP TABLE TJobParts
IF OBJECT_ID( 'TParts' )						IS NOT NULL DROP TABLE TParts
IF OBJECT_ID( 'TVendors' )						IS NOT NULL DROP TABLE TVendors
IF OBJECT_ID( 'TReviews' )						IS NOT NULL DROP TABLE TReviews
IF OBJECT_ID( 'TJobs' )							IS NOT NULL DROP TABLE TJobs
IF OBJECT_ID( 'TEmployees' )					IS NOT NULL DROP TABLE TEmployees
IF OBJECT_ID( 'TStatuses' )						IS NOT NULL DROP TABLE TStatuses
IF OBJECT_ID( 'TServices' )						IS NOT NULL DROP TABLE TServices
IF OBJECT_ID( 'TPaymentTypes' )					IS NOT NULL DROP TABLE TPaymentTypes
IF OBJECT_ID( 'TCustomers' )					IS NOT NULL DROP TABLE TCustomers
IF OBJECT_ID( 'TCities' )						IS NOT NULL DROP TABLE TCities
IF OBJECT_ID( 'TStates' )						IS NOT NULL DROP TABLE TStates


-- --------------------------------------------------------------------------------
-- Drop Views
-- --------------------------------------------------------------------------------

IF OBJECT_ID( 'vCustomers' )					IS NOT NULL DROP VIEW vCustomers
IF OBJECT_ID( 'VParts' )						IS NOT NULL DROP VIEW vParts


-- --------------------------------------------------------------------------------
-- Create Tables
-- --------------------------------------------------------------------------------
CREATE TABLE TCustomers
(
	 intCustomerID		INTEGER			NOT NULL
	,strFirstName		VARCHAR(50)		NOT NULL
	,strLastName		VARCHAR(50)		NOT NULL
	,strAddress			VARCHAR(50)		NOT NULL
	,strCity			VARCHAR(50)		NOT NULL
	,intStateID			INTEGER			NOT NULL
	,strZip				VARCHAR(50)		NOT NULL
	,strPhoneNumber		VARCHAR(50)		NOT NULL
	,strEmail			VARCHAR(50)		NOT NULL
	,CONSTRAINT TCustomers_PK PRIMARY KEY ( intCustomerID )
)

CREATE TABLE TVendors
(
	 intVendorID		INTEGER			NOT NULL
	,strVendortName		VARCHAR(50)		NOT NULL
	,strContactName		VARCHAR(50)		NOT NULL
	,strAddress			VARCHAR(50)		NOT NULL
	,strCity			VARCHAR(50)		NOT NULL
	,intStateID			INTEGER			NOT NULL
	,strZip				VARCHAR(50)		NOT NULL
	,strPhoneNumber		VARCHAR(50)		NOT NULL
	,strEmail			VARCHAR(50)		NOT NULL
	,CONSTRAINT TVendors_PK PRIMARY KEY ( intVendorID )
)

CREATE TABLE TReviews
(
	 intReviewID			INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,intJobID				INTEGER			NOT NULL
	,strReview				VARCHAR(500)	NOT NULL
	,CONSTRAINT TReviews_PK PRIMARY KEY ( intReviewID )
)

CREATE TABLE TCities
(
	 intCityID				INTEGER			NOT NULL
	,strCity				VARCHAR(50)		NOT NULL
	,CONSTRAINT TTCities_PK PRIMARY KEY ( intCityID )
)

CREATE TABLE TStates
(
	 intStateID		INTEGER			NOT NULL
	,strStateAbb	VARCHAR(50)		NOT NULL
	,strState		VARCHAR(50)		NOT NULL
	,CONSTRAINT TStates_PK PRIMARY KEY ( intStateID )
)

CREATE TABLE TJobs
(
	 intJobID			INTEGER			NOT NULL
	,intCustomerID		INTEGER			NOT NULL
	,strJobDesc			VARCHAR(500)	NOT NULL
	,intNumEmployee		INTEGER			NOT NULL
	,intDuration		INTEGER			NOT NULL
	,intStatusID		INTEGER			NOT NULL
	,dtDate				DATE			NOT NULL
	,CONSTRAINT TJobs_PK PRIMARY KEY ( intJobID )
)

CREATE TABLE TParts
(
	 intPartID				INTEGER			NOT NULL
	,intVendorID			INTEGER			NOT NULL
	,strSerialNumber		VARCHAR(50)		NOT NULL
	,strPartDesc			VARCHAR(50)		NOT NULL
	,intQuantity			INTEGER			NOT NULL
	,decUnitPurchaseCost	DECIMAL			NOT NULL
	,decUniteSaleCost		DECIMAL			NOT NULL
	,intAmountSold			INTEGER			NOT NULL
	,CONSTRAINT TParts_PK PRIMARY KEY ( intPartID )
)

CREATE TABLE TJobParts
(
	 intJobPartID			INTEGER			NOT NULL
	,intJobID				INTEGER			NOT NULL
	,intPartID				INTEGER			NOT NULL
	,intPartQuantity		INTEGER			NOT NULL
	,CONSTRAINT TJobParts_PK PRIMARY KEY ( intJobPartID )
)

CREATE TABLE TJobEmployees
(
	 intJobEmployeeID		INTEGER			NOT NULL
	,intJobID				INTEGER			NOT NULL
	,intEmployeeID			INTEGER			NOT NULL
	,CONSTRAINT TJobEmployees_PK PRIMARY KEY ( intJobEmployeeID )
)

CREATE TABLE TEmployees
(
	 intEmployeeID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(50)		NOT NULL
	,strLastName			VARCHAR(50)		NOT NULL
	,CONSTRAINT TEmployees_PK PRIMARY KEY ( intEmployeeID )
)

CREATE TABLE TStatuses
(
	 intStatusID			INTEGER			NOT NULL
	,strStatus				VARCHAR(50)		NOT NULL
	,CONSTRAINT TStatuses_PK PRIMARY KEY ( intStatusID )
)

CREATE TABLE TJobServices
(
	 intJobServiceID		INTEGER			NOT NULL
	,intServiceID			INTEGER			NOT NULL
	,intJobID				INTEGER			NOT NULL
	,CONSTRAINT	TJobServices_PK PRIMARY KEY ( intJobServiceID )
)

CREATE TABLE TServices
(
	 intServiceID			INTEGER			NOT NULL
	,strServiceDesc			VARCHAR(50)		NOT NULL
	,CONSTRAINT	TServices_PK PRIMARY KEY ( intServiceID )
)

CREATE TABLE TInvoices
(
	 intInvoiceID			INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,intJobID				INTEGER			NOT NULL
	,dtDateDue				DATE			NOT NULL
	,intPaymentTypeID		INTEGER			NOT NULL
	,CONSTRAINT TInvoices_PK PRIMARY KEY ( intInvoiceID)
)

CREATE TABLE TPaymentTypes
(
	 intPaymentTypeID		INTEGER			NOT NULL
	,strServiceDesc			VARCHAR(50)		NOT NULL
	,CONSTRAINT	TPaymentTypes_PK PRIMARY KEY ( intPaymentTypeID )
)

CREATE TABLE TCreditCards
(
	 intCreditCardID		INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,strCardholderName		VARCHAR(50)		NOT NULL
	,strExpiration			VARCHAR(5)		NOT NULL
	,strCVV					VARCHAR(3)		NOT NULL
	,CONSTRAINT TCreditCards_PK PRIMARY KEY ( intCreditCardID )
)

CREATE TABLE TCustomerPayments
(
	 intCustomerPaymentID	INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,intPaymentTypeID		INTEGER			NOT NULL
	,CONSTRAINT TCustomerPayments_PK PRIMARY KEY ( intCustomerPaymentID )
)

-- --------------------------------------------------------------------------------
-- Identify and Create Foreign Keys
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column(s)
-- -	-----							------						---------
-- 1	TCustomers						TStates						intStateID
-- 2	TCustomers						TCities						intCityID
-- 3	TVendors						TStates						intStateID
-- 4	TVendors						TCities						intCityID
-- 5	TJobs							TCustomers					intCustomerID
-- 6    TJobs							TStatuses					intStatusID
-- 7	TReviews						TCustomers					intCustomerID
-- 8	TReviews						TJobs						intJobID
-- 9	TParts							TVendors					intVendorID
-- 10	TJobParts						TJobs						intJobID
-- 11	TJobParts						TParts						intPartID
-- 12	TJobEmployees					TJobs						intJobID
-- 13	TJobEmployees					TEmployees					intEmployeeID
-- 14	TJobServices					TServices					intServiceID
-- 15	TInvoices						TCustomers					intCustomerID
-- 16	TInvoices						TJobs						intJobID
-- 17	TInvoices						TPaymentTypes				intPaymentTypeID


-- 1
ALTER TABLE TCustomers ADD CONSTRAINT TCustomers_TStates_FK
FOREIGN KEY ( intStateID ) REFERENCES TStates ( intStateID )

-- 2
--ALTER TABLE TCustomers ADD CONSTRAINT TCustomers_TCities_FK
--FOREIGN KEY ( intCityID ) REFERENCES TCities ( intCityID )

-- 3
ALTER TABLE TVendors ADD CONSTRAINT TVendors_TStates_FK
FOREIGN KEY ( intStateID ) REFERENCES TStates ( intStateID )

-- 4
--ALTER TABLE TVendors ADD CONSTRAINT TVendors_TCities_FK
--FOREIGN KEY ( intCityID ) REFERENCES TCities ( intCityID )

-- 5
ALTER TABLE TJobs ADD CONSTRAINT TJobs_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 6
ALTER TABLE TJobs ADD CONSTRAINT TJobs_TStatuses_FK
FOREIGN KEY ( intStatusID ) REFERENCES TStatuses ( intStatusID )

-- 7
ALTER TABLE TReviews ADD CONSTRAINT TReviews_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 8
ALTER TABLE TReviews ADD CONSTRAINT TReviews_TJobs_FK
FOREIGN KEY ( intJobID ) REFERENCES TJobs ( intJobID )

-- 9
ALTER TABLE TParts ADD CONSTRAINT TParts_TVendors_FK
FOREIGN KEY ( intVendorID ) REFERENCES TVendors ( intVendorID )

-- 10
ALTER TABLE TJobParts ADD CONSTRAINT TJobParts_TJobs_FK
FOREIGN KEY ( intJobID ) REFERENCES TJobs ( intJobID )

-- 11
ALTER TABLE TJobParts ADD CONSTRAINT TJobParts_TParts_FK
FOREIGN KEY ( intPartID ) REFERENCES TParts ( intPartID )

-- 12
ALTER TABLE TJobEmployees ADD CONSTRAINT TJobEmployees_TJobs_FK
FOREIGN KEY ( intJobID ) REFERENCES TJobs ( intJobID )

-- 13
ALTER TABLE TJobEmployees ADD CONSTRAINT TJobEmployees_TEmployees_FK
FOREIGN KEY ( intEmployeeID ) REFERENCES TEmployees ( intEmployeeID )

-- 14
ALTER TABLE TJobServices ADD CONSTRAINT TJobServices_TServices_FK
FOREIGN KEY ( intServiceID ) REFERENCES TServices ( intServiceID )

-- 15
ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 16
ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TJobs_FK
FOREIGN KEY ( intJobID ) REFERENCES TJobs ( intJobID )

-- 17
ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TPaymentTypeID_FK
FOREIGN KEY ( intPaymentTypeID ) REFERENCES TPaymentTypes ( intPaymentTypeID )


---- --------------------------------------------------------------------------------
---- Add Necessary Data
---- --------------------------------------------------------------------------------

INSERT into TStates values 
(1, 'AK', 'Alaska'),
(2, 'AL', 'Alabama'),
(3, 'AZ', 'Arizona'),
(4, 'AR', 'Arkansas'),
(5, 'CA', 'California'),
(6, 'CO', 'Colorado'),
(7, 'CT', 'Connecticut'),
(8, 'DE', 'Delaware'),
(9, 'DC', 'District of Columbia'),
(10, 'FL', 'Florida'),
(11, 'GA', 'Georgia'),
(12, 'HI', 'Hawaii'),
(13, 'ID', 'Idaho'),
(14, 'IL', 'Illinois'),
(15, 'IN', 'Indiana'),
(16, 'IA', 'Iowa'),
(17, 'KS', 'Kansas'),
(18, 'KY', 'Kentucky'),
(19, 'LA', 'Louisiana'),
(20, 'ME', 'Maine'),
(21, 'MD', 'Maryland'),
(22, 'MA', 'Massachusetts'),
(23, 'MI', 'Michigan'),
(24, 'MN', 'Minnesota'),
(25, 'MS', 'Mississippi'),
(26, 'MO', 'Missouri'),
(27, 'MT', 'Montana'),
(28, 'NE', 'Nebraska'),
(29, 'NV', 'Nevada'),
(30, 'NH', 'New Hampshire'),
(31, 'NJ', 'New Jersey'),
(32, 'NM', 'New Mexico'),
(33, 'NY', 'New York'),
(34, 'NC', 'North Carolina'),
(35, 'ND', 'North Dakota'),
(36, 'OH', 'Ohio'),
(37, 'OK', 'Oklahoma'),
(38, 'OR', 'Oregon'),
(39, 'PA', 'Pennsylvania'),
(40, 'PR', 'Puerto Rico'),
(41, 'RI', 'Rhode Island'),
(42, 'SC', 'South Carolina'),
(43, 'SD', 'South Dakota'),
(44, 'TN', 'Tennessee'),
(45, 'TX', 'Texas'),
(46, 'UT', 'Utah'),
(47, 'VT', 'Vermont'),
(48, 'VA', 'Virginia'),
(49, 'WA', 'Washington'),
(50, 'WV', 'West Virginia'),
(51, 'WI', 'Wisconsin'),
(52, 'WY', 'Wyoming');


/*
INSERT INTO TCities values
(1, 'Aberdeen'),
(2, 'Abilene'),
(3, 'Absecon'),
(4, 'Akron'),
(5, 'Albany'),
(6, 'Alliance'),
(7, 'Amarillo'),
(8, 'Anaheim'),
(9, 'Anchorage'),
(10, 'Ann Arbor'),
(11, 'Annandale'),
(12, 'Arlington'),
(13, 'Arlington Heights'),
(14, 'Ashland'),
(15, 'Aston'),
(16, 'Astoria'),
(17, 'Atlanta'),
(18, 'Atlantic City'),
(19, 'Austin'),
(20, 'Baltimore'),
(21, 'Bangor'),
(22, 'Barberton'),
(23, 'Beachwood'),
(24, 'Beaverton'),
(25, 'Bellflower'),
(26, 'Beloit'),
(27, 'Berkeley'),
(28, 'Beverly Hills'),
(29, 'Biloxi'),
(30, 'Bladensburg'),
(31, 'Bloomfield'),
(32, 'Bloomington'),
(33, 'Bohemia'),
(34, 'Boise'),
(35, 'Boston'),
(36, 'Bothell'),
(37, 'Boulder'),
(38, 'Bowling Green'),
(39, 'Brandon'),
(40, 'Bridgeport'),
(41, 'Bridgewater'),
(42, 'Brighton'),
(43, 'Bronx'),
(44, 'Brook Park'),
(45, 'Brooklyn'),
(46, 'Broussard'),
(47, 'Bucyrus'),
(48, 'Buffalo'),
(49, 'Burlingame'),
(50, 'Burlington'),
(51, 'Burnsville'),
(52, 'Butte'),
(53, 'Camarillo'),
(54, 'Cambridge'),
(55, 'Canton'),
(56, 'Carson City'),
(57, 'Cathedral City'),
(58, 'Cedar Grove'),
(59, 'Chagrin Falls'),
(60, 'Chapel Hill'),
(61, 'Cherry Hill'),
(62, 'Cheyenne'),
(63, 'Chicago'),
(64, 'Cincinnati'),
(65, 'Clarks Summit'),
(66, 'Cleveland'),
(67, 'Clifton'),
(68, 'Clinton'),
(69, 'Clovis'),
(70, 'Coatesville'),
(71, 'Cocoa'),
(72, 'College Station'),
(73, 'Colorado Springs'),
(74, 'Columbia'),
(75, 'Columbus'),
(76, 'Concord'),
(77, 'Conroe'),
(78, 'Coram'),
(79, 'Costa Mesa'),
(80, 'Crestview'),
(81, 'Crystal River'),
(82, 'Dallas'),
(83, 'Daytona Beach'),
(84, 'Dearborn'),
(85, 'Deer Park'),
(86, 'Denver'),
(87, 'Denville'),
(88, 'Des Moines'),
(89, 'Douglasville'),
(90, 'Dunellen'),
(91, 'East Lansing'),
(92, 'Easton'),
(93, 'El Cajon'),
(94, 'El Monte'),
(95, 'El Paso'),
(96, 'Elk Grove Village'),
(97, 'Elkhart'),
(98, 'Englewood'),
(99, 'Erie'),
(100, 'Escondido'),
(101, 'Eugene'),
(102, 'Euless'),
(103, 'Evanston'),
(104, 'Fairbanks'),
(105, 'Fairfax'),
(106, 'Fairfield'),
(107, 'Fargo'),
(108, 'Fayetteville'),
(109, 'Findlay'),
(110, 'Flemington'),
(111, 'Fort Wayne'),
(112, 'Fort Worth'),
(113, 'Fortville'),
(114, 'Freehold'),
(115, 'Garden City'),
(116, 'Gardena'),
(117, 'Glen Burnie'),
(118, 'Grand Rapids'),
(119, 'Green Bay'),
(120, 'Greensboro'),
(121, 'Hackensack'),
(122, 'Hamilton'),
(123, 'Hampstead'),
(124, 'Hanover'),
(125, 'Harrisburg'),
(126, 'Harrison'),
(127, 'Hatfield'),
(128, 'Hays'),
(129, 'Hayward'),
(130, 'Hazleton'),
(131, 'Hialeah'),
(132, 'Hicksville'),
(133, 'High Point'),
(134, 'Highland Park'),
(135, 'Hilo'),
(136, 'Homestead'),
(137, 'Homosassa'),
(138, 'Honolulu'),
(139, 'Hopkins'),
(140, 'Houma'),
(141, 'Huntingdon Valley'),
(142, 'Huntington Beach'),
(143, 'Hyattsville'),
(144, 'Indianapolis'),
(145, 'Irving'),
(146, 'Jackson'),
(147, 'Jacksonville'),
(148, 'Jenkintown'),
(149, 'Jersey City'),
(150, 'Johnston'),
(151, 'Katonah'),
(152, 'Kearny'),
(153, 'Kennedale'),
(154, 'Kent'),
(155, 'Kerrville'),
(156, 'King of Prussia'),
(157, 'Kulpsville'),
(158, 'La Mesa'),
(159, 'Lafayette'),
(160, 'Lake Worth'),
(161, 'Lancaster'),
(162, 'Lansing'),
(163, 'Laredo'),
(164, 'Las Cruces'),
(165, 'Little Falls'),
(166, 'Little Rock'),
(167, 'Littleton'),
(168, 'Livingston'),
(169, 'London'),
(170, 'Long Island City'),
(171, 'Longwood'),
(172, 'Los Angeles'),
(173, 'Lynbrook'),
(174, 'Lyndhurst'),
(175, 'Madison'),
(176, 'Margate City'),
(177, 'Massapequa'),
(178, 'Mc Lean'),
(179, 'Mc Minnville'),
(180, 'Memphis'),
(181, 'Meridian'),
(182, 'Mesa'),
(183, 'Mesquite'),
(184, 'Metairie'),
(185, 'Miami'),
(186, 'Middle Island'),
(187, 'Middleboro'),
(188, 'Middlesex'),
(189, 'Milan'),
(190, 'Milwaukee'),
(191, 'Minneapolis'),
(192, 'Monroe Township'),
(193, 'Moscow'),
(194, 'Moss'),
(195, 'Mount Vernon'),
(196, 'Muskegon'),
(197, 'Nashville'),
(198, 'New Bedford'),
(199, 'New Haven'),
(200, 'New Orleans'),
(201, 'New York'),
(202, 'Newark'),
(203, 'Newport News'),
(204, 'Niles'),
(205, 'North Attleboro'),
(206, 'North Haven'),
(207, 'Northfield'),
(208, 'Northridge'),
(209, 'Norwalk'),
(210, 'Novato'),
(211, 'Nutley'),
(212, 'Oak Hill'),
(213, 'Oakland'),
(214, 'Oakley'),
(215, 'Old Forge'),
(216, 'Omaha'),
(217, 'Ontario'),
(218, 'Opa Locka'),
(219, 'Orange'),
(220, 'Orlando'),
(221, 'Oroville'),
(222, 'Overland Park'),
(223, 'Owings Mills'),
(224, 'Pacifica'),
(225, 'Palatine'),
(226, 'Paramus'),
(227, 'Parkville'),
(228, 'Pasadena'),
(229, 'Passaic'),
(230, 'Paterson'),
(231, 'Pearl'),
(232, 'Pearl City'),
(233, 'Pelham'),
(234, 'Peoria'),
(235, 'Perrysburg'),
(236, 'Philadelphia'),
(237, 'Phoenix'),
(238, 'Pittstown'),
(239, 'Plainfield'),
(240, 'Plaistow'),
(241, 'Plano'),
(242, 'Pomona'),
(243, 'Port Jervis'),
(244, 'Portland'),
(245, 'Preston'),
(246, 'Prineville'),
(247, 'Providence'),
(248, 'Raleigh'),
(249, 'Ramsey'),
(250, 'Randolph'),
(251, 'Reno'),
(252, 'Richboro'),
(253, 'Richland'),
(254, 'Richmond'),
(255, 'Ridgefield Park'),
(256, 'Riverside'),
(257, 'Riverton'),
(258, 'Rochester'),
(259, 'Rock Springs'),
(260, 'Rockaway'),
(261, 'Rockford'),
(262, 'Rohnert Park'),
(263, 'Rolling Meadows'),
(264, 'Ronkonkoma'),
(265, 'Roseville'),
(266, 'Round Rock'),
(267, 'Sacramento'),
(268, 'Saint Joseph'),
(269, 'Saint Louis'),
(270, 'Saint Paul'),
(271, 'Salem'),
(272, 'Salisbury'),
(273, 'Salt Lake City'),
(274, 'San Antonio'),
(275, 'San Bernardino'),
(276, 'San Carlos'),
(277, 'San Diego'),
(278, 'San Francisco'),
(279, 'San Gabriel'),
(280, 'San Jose'),
(281, 'San Leandro'),
(282, 'San Mateo'),
(283, 'San Ramon'),
(284, 'Santa Ana'),
(285, 'Santa Clara'),
(286, 'Santa Rosa'),
(287, 'Saratoga'),
(288, 'Satellite Beach'),
(289, 'Scottsdale'),
(290, 'Scranton'),
(291, 'Seattle'),
(292, 'Shakopee'),
(293, 'Shawnee'),
(294, 'Sioux Falls'),
(295, 'Smithfield'),
(296, 'Somerset'),
(297, 'Somerville'),
(298, 'South Bend'),
(299, 'South San Francisco'),
(300, 'Southampton'),
(301, 'Southfield'),
(302, 'Spartanburg'),
(303, 'Staten Island'),
(304, 'Sterling Heights'),
(305, 'Stevens Point'),
(306, 'Stockton'),
(307, 'Strongsville'),
(308, 'Syosset'),
(309, 'Syracuse'),
(310, 'Tacoma'),
(311, 'Tampa'),
(312, 'Taylor'),
(313, 'Thousand Oaks'),
(314, 'Thousand Palms'),
(315, 'Toledo'),
(316, 'Toms River'),
(317, 'Trenton'),
(318, 'Trion'),
(319, 'Troy'),
(320, 'Tullahoma'),
(321, 'Tulsa'),
(322, 'Union City'),
(323, 'Utica'),
(324, 'Valley Park'),
(325, 'Van Nuys'),
(326, 'Vashon'),
(327, 'Vestal'),
(328, 'Waco'),
(329, 'Warren'),
(330, 'Washington'),
(331, 'Waterford'),
(332, 'Wayne'),
(333, 'Wellsville'),
(334, 'Westborough'),
(335, 'Westbury'),
(336, 'Wheeling'),
(337, 'Whippany'),
(338, 'Wichita Falls'),
(339, 'Wilmington'),
(340, 'Worcester'),
(341, 'Yonkers'),
(342, 'York')
*/


INSERT INTO TCustomers VALUES
(1, 'James', 'Butt', '6649 N Blue Gum St', 'New Orleans', 29, '70116', '504-621-8927', 'jbutt@gmail.com'),
(2, 'Josephine', 'Darakjy', '4 B Blue Ridge Blvd', 'Brighton', 37, '48116', '810-292-9388', 'josephine_darakjy@darakjy.org'),
(3, 'Art', 'Venere', '8 W Cerritos Ave #54', 'Bridgeport', 23, '8014', '856-636-8749', 'art@venere.org'),
(4, 'Lenna', 'Paprocki', '639 Main St', 'Anchorage', 49, '99501', '907-385-4412', 'lpaprocki@hotmail.com'),
(5, 'Donette', 'Foller', '34 Center St', 'Hamilton', 26, '45011', '513-570-1893', 'donette.foller@cox.net'),
(6, 'Simona', 'Morasca', '3 Mcauley Dr', 'Ashland', 34, '44805', '419-503-2484', 'simona@morasca.com'),
(7, 'Mitsue', 'Tollner', '7 Eads St', 'Chicago', 23, '60632', '773-573-6914', 'mitsue_tollner@yahoo.com'),
(8, 'Leota', 'Dilliard', '7 W Jackson Blvd', 'San Jose', 1, '95111', '408-752-3500', 'leota@hotmail.com'),
(9, 'Sage', 'Wieser', '5 Boston Ave #88', 'Sioux Falls', 23, '57105', '605-414-2147', 'sage_wieser@cox.net'),
(10, 'Kris', 'Marrier', '228 Runamuck Pl #2808', 'Baltimore', 44, '21224', '410-655-8723', 'kris@gmail.com'),
(11, 'Minna', 'Amigon', '2371 Jerrold Ave', 'Kulpsville', 32, '19443', '215-874-1229', 'minna_amigon@yahoo.com'),
(12, 'Abel', 'Maclead', '37275 St  Rt 17m M', 'Middle Island', 17, '11953', '631-335-3414', 'amaclead@gmail.com'),
(13, 'Kiley', 'Caldarera', '25 E 75th St #69', 'Los Angeles', 11, '90034', '310-498-5651', 'kiley.caldarera@aol.com'),
(14, 'Graciela', 'Ruta', '98 Connecticut Ave Nw', 'Chagrin Falls', 6, '44023', '440-780-8425', 'gruta@cox.net'),
(15, 'Cammy', 'Albares', '56 E Morehead St', 'Laredo', 14, '78045', '956-537-6195', 'calbares@gmail.com'),
(16, 'Mattie', 'Poquette', '73 State Road 434 E', 'Phoenix', 10, '85013', '602-277-4385', 'mattie@aol.com'),
(17, 'Meaghan', 'Garufi', '69734 E Carrillo St', 'Mc Minnville', 8, '37110', '931-313-9635', 'meaghan@hotmail.com'),
(18, 'Gladys', 'Rim', '322 New Horizon Blvd', 'Milwaukee', 12, '53207', '414-661-9598', 'gladys.rim@rim.org'),
(19, 'Yuki', 'Whobrey', '1 State Route 27', 'Taylor', 1, '48180', '313-288-7937', 'yuki_whobrey@aol.com'),
(20, 'Fletcher', 'Flosi', '394 Manchester Blvd', 'Rockford', 26, '61109', '815-828-2147', 'fletcher.flosi@yahoo.com'),
(21, 'Bette', 'Nicka', '6 S 33rd St', 'Aston', 18, '19014', '610-545-3615', 'bette_nicka@cox.net'),
(22, 'Veronika', 'Inouye', '6 Greenleaf Ave', 'San Jose', 14, '95111', '408-540-1785', 'vinouye@aol.com'),
(23, 'Willard', 'Kolmetz', '618 W Yakima Ave', 'Irving', 39, '75062', '972-303-9197', 'willard@hotmail.com'),
(24, 'Maryann', 'Royster', '74 S Westgate St', 'Albany', 52, '12204', '518-966-7987', 'mroyster@royster.com'),
(25, 'Alisha', 'Slusarski', '3273 State St', 'Middlesex', 3, '8846', '732-658-3154', 'alisha@slusarski.com'),
(26, 'Allene', 'Iturbide', '1 Central Ave', 'Stevens Point', 7, '54481', '715-662-6764', 'allene_iturbide@cox.net'),
(27, 'Chanel', 'Caudy', '86 Nw 66th St #8673', 'Shawnee', 44, '66218', '913-388-2079', 'chanel.caudy@caudy.org'),
(28, 'Ezekiel', 'Chui', '2 Cedar Ave #84', 'Easton', 18, '21601', '410-669-1642', 'ezekiel@chui.com'),
(29, 'Willow', 'Kusko', '90991 Thorburn Ave', 'New York', 45, '10011', '212-582-4976', 'wkusko@yahoo.com'),
(30, 'Bernardo', 'Figeroa', '386 9th Ave N', 'Conroe', 19, '77301', '936-336-3951', 'bfigeroa@aol.com'),
(31, 'Ammie', 'Corrio', '74874 Atlantic Ave', 'Columbus', 18, '43215', '614-801-9788', 'ammie@corrio.com'),
(32, 'Francine', 'Vocelka', '366 South Dr', 'Las Cruces', 51, '88011', '505-977-3911', 'francine_vocelka@vocelka.com'),
(33, 'Ernie', 'Stenseth', '45 E Liberty St', 'Ridgefield Park', 23, '7660', '201-709-6245', 'ernie_stenseth@aol.com'),
(34, 'Albina', 'Glick', '4 Ralph Ct', 'Dunellen', 21, '8812', '732-924-7882', 'albina@glick.com'),
(35, 'Alishia', 'Sergi', '2742 Distribution Way', 'New York', 48, '10025', '212-860-1579', 'asergi@gmail.com'),
(36, 'Solange', 'Shinko', '426 Wolf St', 'Metairie', 27, '70002', '504-979-9175', 'solange@shinko.com'),
(37, 'Jose', 'Stockham', '128 Bransten Rd', 'New York', 27, '10011', '212-675-8570', 'jose@yahoo.com'),
(38, 'Rozella', 'Ostrosky', '17 Morena Blvd', 'Camarillo', 46, '93012', '805-832-6163', 'rozella.ostrosky@ostrosky.com'),
(39, 'Valentine', 'Gillian', '775 W 17th St', 'San Antonio', 23, '78204', '210-812-9597', 'valentine_gillian@gmail.com'),
(40, 'Kati', 'Rulapaugh', '6980 Dorsett Rd', 'Abilene', 40, '67410', '785-463-7829', 'kati.rulapaugh@hotmail.com'),
(41, 'Youlanda', 'Schemmer', '2881 Lewis Rd', 'Prineville', 25, '97754', '541-548-8197', 'youlanda@aol.com'),
(42, 'Dyan', 'Oldroyd', '7219 Woodfield Rd', 'Overland Park', 1, '66204', '913-413-4604', 'doldroyd@aol.com'),
(43, 'Roxane', 'Campain', '1048 Main St', 'Fairbanks', 49, '99708', '907-231-4722', 'roxane@hotmail.com'),
(44, 'Lavera', 'Perin', '678 3rd Ave', 'Miami', 19, '33196', '305-606-7291', 'lperin@perin.org'),
(45, 'Erick', 'Ferencz', '20 S Babcock St', 'Fairbanks', 43, '99712', '907-741-1044', 'erick.ferencz@aol.com'),
(46, 'Fatima', 'Saylors', '2 Lighthouse Ave', 'Hopkins', 46, '55343', '952-768-2416', 'fsaylors@saylors.org'),
(47, 'Jina', 'Briddick', '38938 Park Blvd', 'Boston', 25, '2128', '617-399-5124', 'jina_briddick@briddick.com'),
(48, 'Kanisha', 'Waycott', '5 Tomahawk Dr', 'Los Angeles', 15, '90006', '323-453-2780', 'kanisha_waycott@yahoo.com'),
(49, 'Emerson', 'Bowley', '762 S Main St', 'Madison', 47, '53711', '608-336-7444', 'emerson.bowley@bowley.org'),
(50, 'Blair', 'Malet', '209 Decker Dr', 'Philadelphia', 2, '19132', '215-907-9111', 'bmalet@yahoo.com'),
(51, 'Brock', 'Bolognia', '4486 W O St #1', 'New York', 17, '10003', '212-402-9216', 'bbolognia@yahoo.com'),
(52, 'Lorrie', 'Nestle', '39 S 7th St', 'Tullahoma', 15, '37388', '931-875-6644', 'lnestle@hotmail.com'),
(53, 'Sabra', 'Uyetake', '98839 Hawthorne Blvd #6101', 'Columbia', 17, '29201', '803-925-5213', 'sabra@uyetake.org'),
(54, 'Marjory', 'Mastella', '71 San Mateo Ave', 'Wayne', 46, '19087', '610-814-5533', 'mmastella@mastella.com'),
(55, 'Karl', 'Klonowski', '76 Brooks St #9', 'Flemington', 27, '8822', '908-877-6135', 'karl_klonowski@yahoo.com'),
(56, 'Tonette', 'Wenner', '4545 Courthouse Rd', 'Westbury', 48, '11590', '516-968-6051', 'twenner@aol.com'),
(57, 'Amber', 'Monarrez', '14288 Foster Ave #4121', 'Jenkintown', 1, '19046', '215-934-8655', 'amber_monarrez@monarrez.org'),
(58, 'Shenika', 'Seewald', '4 Otis St', 'Van Nuys', 7, '91405', '818-423-4007', 'shenika@gmail.com'),
(59, 'Delmy', 'Ahle', '65895 S 16th St', 'Providence', 39, '2909', '401-458-2547', 'delmy.ahle@hotmail.com'),
(60, 'Deeanna', 'Juhas', '14302 Pennsylvania Ave', 'Huntingdon Valley', 32, '19006', '215-211-9589', 'deeanna_juhas@gmail.com'),
(61, 'Blondell', 'Pugh', '201 Hawk Ct', 'Providence', 17, '2904', '401-960-8259', 'bpugh@aol.com'),
(62, 'Jamal', 'Vanausdal', '53075 Sw 152nd Ter #615', 'Monroe Township', 36, '8831', '732-234-1546', 'jamal@vanausdal.org'),
(63, 'Cecily', 'Hollack', '59 N Groesbeck Hwy', 'Austin', 1, '78731', '512-486-3817', 'cecily@hollack.org'),
(64, 'Carmelina', 'Lindall', '2664 Lewis Rd', 'Littleton', 44, '80126', '303-724-7371', 'carmelina_lindall@lindall.com'),
(65, 'Maurine', 'Yglesias', '59 Shady Ln #53', 'Milwaukee', 27, '53214', '414-748-1374', 'maurine_yglesias@yglesias.com'),
(66, 'Tawna', 'Buvens', '3305 Nabell Ave #679', 'New York', 42, '10009', '212-674-9610', 'tawna@gmail.com'),
(67, 'Penney', 'Weight', '18 Fountain St', 'Anchorage', 26, '99515', '907-797-9628', 'penney_weight@aol.com'),
(68, 'Elly', 'Morocco', '7 W 32nd St', 'Erie', 21, '16502', '814-393-5571', 'elly_morocco@gmail.com'),
(69, 'Ilene', 'Eroman', '2853 S Central Expy', 'Glen Burnie', 48, '21061', '410-914-9018', 'ilene.eroman@hotmail.com'),
(70, 'Vallie', 'Mondella', '74 W College St', 'Boise', 19, '83707', '208-862-5339', 'vmondella@mondella.com'),
(71, 'Kallie', 'Blackwood', '701 S Harrison Rd', 'San Francisco', 11, '94104', '415-315-2761', 'kallie.blackwood@gmail.com'),
(72, 'Johnetta', 'Abdallah', '1088 Pinehurst St', 'Chapel Hill', 42, '27514', '919-225-9345', 'johnetta_abdallah@aol.com'),
(73, 'Bobbye', 'Rhym', '30 W 80th St #1995', 'San Carlos', 2, '94070', '650-528-5783', 'brhym@rhym.com'),
(74, 'Micaela', 'Rhymes', '20932 Hedley St', 'Concord', 22, '94520', '925-647-3298', 'micaela_rhymes@gmail.com'),
(75, 'Tamar', 'Hoogland', '2737 Pistorio Rd #9230', 'London', 6, '43140', '740-343-8575', 'tamar@hotmail.com'),
(76, 'Moon', 'Parlato', '74989 Brandon St', 'Wellsville', 1, '14895', '585-866-8313', 'moon@yahoo.com'),
(77, 'Laurel', 'Reitler', '6 Kains Ave', 'Baltimore', 10, '21215', '410-520-4832', 'laurel_reitler@reitler.com'),
(78, 'Delisa', 'Crupi', '47565 W Grand Ave', 'Newark', 30, '7105', '973-354-2040', 'delisa.crupi@crupi.com'),
(79, 'Viva', 'Toelkes', '4284 Dorigo Ln', 'Chicago', 39, '60647', '773-446-5569', 'viva.toelkes@gmail.com'),
(80, 'Elza', 'Lipke', '6794 Lake Dr E', 'Newark', 30, '7104', '973-927-3447', 'elza@yahoo.com'),
(81, 'Devorah', 'Chickering', '31 Douglas Blvd #950', 'Clovis', 37, '88101', '505-975-8559', 'devorah@hotmail.com'),
(82, 'Timothy', 'Mulqueen', '44 W 4th St', 'Staten Island', 24, '10309', '718-332-6527', 'timothy_mulqueen@mulqueen.org'),
(83, 'Arlette', 'Honeywell', '11279 Loytan St', 'Jacksonville', 21, '32254', '904-775-4480', 'ahoneywell@honeywell.com'),
(84, 'Dominque', 'Dickerson', '69 Marquette Ave', 'Hayward', 11, '94545', '510-993-3758', 'dominque.dickerson@dickerson.org'),
(85, 'Lettie', 'Isenhower', '70 W Main St', 'Beachwood', 24, '44122', '216-657-7668', 'lettie_isenhower@yahoo.com'),
(86, 'Myra', 'Munns', '461 Prospect Pl #316', 'Euless', 30, '76040', '817-914-7518', 'mmunns@cox.net'),
(87, 'Stephaine', 'Barfield', '47154 Whipple Ave Nw', 'Gardena', 41, '90247', '310-774-7643', 'stephaine@barfield.com'),
(88, 'Lai', 'Gato', '37 Alabama Ave', 'Evanston', 48, '60201', '847-728-7286', 'lai.gato@gato.org'),
(89, 'Stephen', 'Emigh', '3777 E Richmond St #900', 'Akron', 43, '44302', '330-537-5358', 'stephen_emigh@hotmail.com'),
(90, 'Tyra', 'Shields', '3 Fort Worth Ave', 'Philadelphia', 17, '19106', '215-255-1641', 'tshields@gmail.com'),
(91, 'Tammara', 'Wardrip', '4800 Black Horse Pike', 'Burlingame', 52, '94010', '650-803-1936', 'twardrip@cox.net'),
(92, 'Cory', 'Gibes', '83649 W Belmont Ave', 'San Gabriel', 39, '91776', '626-572-1096', 'cory.gibes@gmail.com'),
(93, 'Danica', 'Bruschke', '840 15th Ave', 'Waco', 42, '76708', '254-782-8569', 'danica_bruschke@gmail.com'),
(94, 'Wilda', 'Giguere', '1747 Calle Amanecer #2', 'Anchorage', 45, '99501', '907-870-5536', 'wilda@cox.net'),
(95, 'Elvera', 'Benimadho', '99385 Charity St #840', 'San Jose', 39, '95110', '408-703-8505', 'elvera.benimadho@cox.net'),
(96, 'Carma', 'Vanheusen', '68556 Central Hwy', 'San Leandro', 30, '94577', '510-503-7169', 'carma@cox.net'),
(97, 'Malinda', 'Hochard', '55 Riverside Ave', 'Indianapolis', 13, '46202', '317-722-5066', 'malinda.hochard@yahoo.com'),
(98, 'Natalie', 'Fern', '7140 University Ave', 'Rock Springs', 52, '82901', '307-704-8713', 'natalie.fern@hotmail.com'),
(99, 'Lisha', 'Centini', '64 5th Ave #1153', 'Mc Lean', 40, '22102', '703-235-3937', 'lisha@centini.org'),
(100, 'Arlene', 'Klusman', '3 Secor Rd', 'New Orleans', 46, '70112', '504-710-5840', 'arlene_klusman@gmail.com'),
(101, 'Alease', 'Buemi', '4 Webbs Chapel Rd', 'Boulder', 33, '80303', '303-301-4946', 'alease@buemi.com'),
(102, 'Louisa', 'Cronauer', '524 Louisiana Ave Nw', 'San Leandro', 13, '94577', '510-828-7047', 'louisa@cronauer.com'),
(103, 'Angella', 'Cetta', '185 Blackstone Bldge', 'Honolulu', 23, '96817', '808-892-7943', 'angella.cetta@hotmail.com'),
(104, 'Cyndy', 'Goldammer', '170 Wyoming Ave', 'Burnsville', 8, '55337', '952-334-9408', 'cgoldammer@cox.net'),
(105, 'Rosio', 'Cork', '4 10th St W', 'High Point', 5, '27263', '336-243-5659', 'rosio.cork@gmail.com'),
(106, 'Celeste', 'Korando', '7 W Pinhook Rd', 'Lynbrook', 19, '11563', '516-509-2347', 'ckorando@hotmail.com'),
(107, 'Twana', 'Felger', '1 Commerce Way', 'Portland', 39, '97224', '503-939-3153', 'twana.felger@felger.org'),
(108, 'Estrella', 'Samu', '64 Lakeview Ave', 'Beloit', 10, '53511', '608-976-7199', 'estrella@aol.com'),
(109, 'Donte', 'Kines', '3 Aspen St', 'Worcester', 17, '1602', '508-429-8576', 'dkines@hotmail.com'),
(110, 'Tiffiny', 'Steffensmeier', '32860 Sierra Rd', 'Miami', 19, '33133', '305-385-9695', 'tiffiny_steffensmeier@cox.net'),
(111, 'Edna', 'Miceli', '555 Main St', 'Erie', 7, '16502', '814-460-2655', 'emiceli@miceli.org'),
(112, 'Sue', 'Kownacki', '2 Se 3rd Ave', 'Mesquite', 42, '75149', '972-666-3413', 'sue@aol.com'),
(113, 'Jesusa', 'Shin', '2239 Shawnee Mission Pky', 'Tullahoma', 26, '37388', '931-273-8709', 'jshin@shin.com'),
(114, 'Rolland', 'Francescon', '2726 Charcot Ave', 'Paterson', 35, '7501', '973-649-2922', 'rolland@cox.net'),
(115, 'Pamella', 'Schmierer', '5161 Dorsett Rd', 'Homestead', 17, '33030', '305-420-8970', 'pamella.schmierer@schmierer.org'),
(116, 'Glory', 'Kulzer', '55892 Jacksonville Rd', 'Owings Mills', 27, '21117', '410-224-9462', 'gkulzer@kulzer.org'),
(117, 'Shawna', 'Palaspas', '5 N Cleveland Massillon Rd', 'Thousand Oaks', 16, '91362', '805-275-3566', 'shawna_palaspas@palaspas.org'),
(118, 'Brandon', 'Callaro', '7 Benton Dr', 'Honolulu', 5, '96819', '808-215-6832', 'brandon_callaro@hotmail.com'),
(119, 'Scarlet', 'Cartan', '9390 S Howell Ave', 'Albany', 17, '31701', '229-735-3378', 'scarlet.cartan@yahoo.com'),
(120, 'Oretha', 'Menter', '8 County Center Dr #647', 'Boston', 11, '2210', '617-418-5043', 'oretha_menter@yahoo.com'),
(121, 'Ty', 'Smith', '4646 Kaahumanu St', 'Hackensack', 17, '7601', '201-672-1553', 'tsmith@aol.com'),
(122, 'Xuan', 'Rochin', '2 Monroe St', 'San Mateo', 48, '94403', '650-933-5072', 'xuan@gmail.com'),
(123, 'Lindsey', 'Dilello', '52777 Leaders Heights Rd', 'Ontario', 29, '91761', '909-639-9887', 'lindsey.dilello@hotmail.com'),
(124, 'Devora', 'Perez', '72868 Blackington Ave', 'Oakland', 7, '94606', '510-955-3016', 'devora_perez@perez.org'),
(125, 'Herman', 'Demesa', '9 Norristown Rd', 'Troy', 25, '12180', '518-497-2940', 'hdemesa@cox.net'),
(126, 'Rory', 'Papasergi', '83 County Road 437 #8581', 'Clarks Summit', 10, '18411', '570-867-7489', 'rpapasergi@cox.net'),
(127, 'Talia', 'Riopelle', '1 N Harlem Ave #9', 'Orange', 12, '7050', '973-245-2133', 'talia_riopelle@aol.com'),
(128, 'Van', 'Shire', '90131 J St', 'Pittstown', 14, '8867', '908-409-2890', 'van.shire@shire.com'),
(129, 'Lucina', 'Lary', '8597 W National Ave', 'Cocoa', 40, '32922', '321-749-4981', 'lucina_lary@cox.net'),
(130, 'Bok', 'Isaacs', '6 Gilson St', 'Bronx', 26, '10468', '718-809-3762', 'bok.isaacs@aol.com'),
(131, 'Rolande', 'Spickerman', '65 W Maple Ave', 'Pearl City', 12, '96782', '808-315-3077', 'rolande.spickerman@spickerman.com'),
(132, 'Howard', 'Paulas', '866 34th Ave', 'Denver', 33, '80231', '303-623-4241', 'hpaulas@gmail.com'),
(133, 'Kimbery', 'Madarang', '798 Lund Farm Way', 'Rockaway', 4, '7866', '973-310-1634', 'kimbery_madarang@cox.net'),
(134, 'Thurman', 'Manno', '9387 Charcot Ave', 'Absecon', 23, '8201', '609-524-3586', 'thurman.manno@yahoo.com'),
(135, 'Becky', 'Mirafuentes', '30553 Washington Rd', 'Plainfield', 33, '7062', '908-877-8409', 'becky.mirafuentes@mirafuentes.com'),
(136, 'Beatriz', 'Corrington', '481 W Lemon St', 'Middleboro', 12, '2346', '508-584-4279', 'beatriz@yahoo.com'),
(137, 'Marti', 'Maybury', '4 Warehouse Point Rd #7', 'Chicago', 45, '60638', '773-775-4522', 'marti.maybury@yahoo.com'),
(138, 'Nieves', 'Gotter', '4940 Pulaski Park Dr', 'Portland', 5, '97202', '503-527-5274', 'nieves_gotter@gmail.com'),
(139, 'Leatha', 'Hagele', '627 Walford Ave', 'Dallas', 35, '75227', '214-339-1809', 'lhagele@cox.net'),
(140, 'Valentin', 'Klimek', '137 Pioneer Way', 'Chicago', 26, '60604', '312-303-5453', 'vklimek@klimek.org'),
(141, 'Melissa', 'Wiklund', '61 13 Stoneridge #835', 'Findlay', 22, '45840', '419-939-3613', 'melissa@cox.net'),
(142, 'Sheridan', 'Zane', '2409 Alabama Rd', 'Riverside', 20, '92501', '951-645-3605', 'sheridan.zane@zane.com'),
(143, 'Bulah', 'Padilla', '8927 Vandever Ave', 'Waco', 50, '76707', '254-463-4368', 'bulah_padilla@hotmail.com'),
(144, 'Audra', 'Kohnert', '134 Lewis Rd', 'Nashville', 15, '37211', '615-406-7854', 'audra@kohnert.com'),
(145, 'Daren', 'Weirather', '9 N College Ave #3', 'Milwaukee', 7, '53216', '414-959-2540', 'dweirather@aol.com'),
(146, 'Fernanda', 'Jillson', '60480 Old Us Highway 51', 'Preston', 33, '21655', '410-387-5260', 'fjillson@aol.com'),
(147, 'Gearldine', 'Gellinger', '4 Bloomfield Ave', 'Irving', 31, '75061', '972-934-6914', 'gearldine_gellinger@gellinger.com'),
(148, 'Chau', 'Kitzman', '429 Tiger Ln', 'Beverly Hills', 28, '90212', '310-560-8022', 'chau@gmail.com'),
(149, 'Theola', 'Frey', '54169 N Main St', 'Massapequa', 19, '11758', '516-948-5768', 'theola_frey@frey.com'),
(150, 'Cheryl', 'Haroldson', '92 Main St', 'Atlantic City', 47, '8401', '609-518-7697', 'cheryl@haroldson.org')




INSERT INTO TVendors VALUES
(1, 'Alinabal Inc', 'Laticia Merced', '72 Mannix Dr', 'Cincinnati', 10, '45203', '513-508-7371', 'lmerced@gmail.com'),
(2, 'Poletto, Kim David Esq', 'Carissa Batman', '12270 Caton Center Dr', 'Eugene', 44, '97401', '541-326-4074', 'carissa.batman@yahoo.com'),
(3, 'Chang, Carolyn Esq', 'Lezlie Craghead', '749 W 18th St #45', 'Smithfield', 38, '27577', '919-533-3762', 'lezlie.craghead@craghead.org'),
(4, 'Silver Bros Inc', 'Ozell Shealy', '8 Industry Ln', 'New York', 13, '10002', '212-332-8435', 'oshealy@hotmail.com'),
(5, 'Newtec Inc', 'Arminda Parvis', '1 Huntwood Ave', 'Phoenix', 43, '85017', '602-906-9419', 'arminda@parvis.com'),
(6, 'Creative Business Systems', 'Reita Leto', '55262 N French Rd', 'Indianapolis', 46, '46240', '317-234-1135', 'reita.leto@gmail.com'),
(7, 'Dal Tile Corporation', 'Yolando Luczki', '422 E 21st St', 'Syracuse', 10, '13214', '315-304-4759', 'yolando@cox.net'),
(8, 'Edward S Katz', 'Lizette Stem', '501 N 19th Ave', 'Cherry Hill', 12, '8002', '856-487-5412', 'lizette.stem@aol.com'),
(9, 'Oh My Goodknits Inc', 'Gregoria Pawlowicz', '455 N Main Ave', 'Garden City', 39, '11530', '516-212-1915', 'gpawlowicz@yahoo.com'),
(10, 'Redeker, Debbie', 'Carin Deleo', '1844 Southern Blvd', 'Little Rock', 15, '72202', '501-308-1040', 'cdeleo@deleo.com'),
(11, 'Desert Sands Motel', 'Chantell Maynerich', '2023 Greg St', 'Saint Paul', 24, '55101', '651-591-2583', 'chantell@yahoo.com'),
(12, 'Cummins Southern Plains Inc', 'Dierdre Yum', '63381 Jenks Ave', 'Philadelphia', 26, '19134', '215-325-3042', 'dyum@yahoo.com'),
(13, 'Lehigh Furn Divsn Lehigh', 'Larae Gudroe', '6651 Municipal Rd', 'Houma', 35, '70360', '985-890-7262', 'larae_gudroe@gmail.com'),
(14, 'United Van Lines Agent', 'Latrice Tolfree', '81 Norris Ave #525', 'Ronkonkoma', 26, '11779', '631-957-7624', 'latrice.tolfree@hotmail.com'),
(15, 'Capitol Reporters', 'Kerry Theodorov', '6916 W Main St', 'Sacramento', 13, '95827', '916-591-3277', 'kerry.theodorov@gmail.com'),
(16, 'Kwik Kopy Printing', 'Dorthy Hidvegi', '9635 S Main St', 'Boise', 9, '83704', '208-649-2373', 'dhidvegi@yahoo.com'),
(17, 'Centro Inc', 'Fannie Lungren', '17 Us Highway 111', 'Round Rock', 27, '78664', '512-587-5746', 'fannie.lungren@yahoo.com'),
(18, 'Campbell, Jan Esq', 'Evangelina Radde', '992 Civic Center Dr', 'Philadelphia', 50, '19123', '215-964-3284', 'evangelina@aol.com'),
(19, 'Evans, C Kelly Esq', 'Novella Degroot', '303 N Radcliffe St', 'Hilo', 31, '96720', '808-477-4775', 'novella_degroot@degroot.org'),
(20, 'Scat Enterprises', 'Clay Hoa', '73 Saint Ann St #86', 'Reno', 50, '89502', '775-501-8109', 'choa@hoa.org'),
(21, 'Nagle, Daniel J Esq', 'Jennifer Fallick', '44 58th St', 'Wheeling', 39, '60090', '847-979-9545', 'jfallick@yahoo.com'),
(22, 'Serendiquity Bed & Breakfast', 'Irma Wolfgramm', '9745 W Main St', 'Randolph', 34, '7869', '973-545-7355', 'irma.wolfgramm@hotmail.com'),
(23, 'Ray Carolyne Realty', 'Eun Coody', '84 Bloomfield Ave', 'Spartanburg', 39, '29301', '864-256-3620', 'eun@yahoo.com'),
(24, 'Berg, Charles E', 'Sylvia Cousey', '287 Youngstown Warren Rd', 'Hampstead', 39, '21074', '410-209-9545', 'sylvia_cousey@cousey.org'),
(25, 'Ray, Milbern D', 'Nana Wrinkles', '6 Van Buren St', 'Mount Vernon', 14, '10553', '914-855-2115', 'nana@aol.com'),
(26, 'Chadds Ford Winery', 'Layla Springe', '229 N Forty Driv', 'New York', 3, '10011', '212-260-3151', 'layla.springe@cox.net'),
(27, 'A R Packaging', 'Joesph Degonia', '2887 Knowlton St #5435', 'Berkeley', 46, '94710', '510-677-9785', 'joesph_degonia@degonia.org'),
(28, 'Corn Popper', 'Annabelle Boord', '523 Marquette Ave', 'Concord', 17, '1742', '978-697-6263', 'annabelle.boord@cox.net'),
(29, 'Birite Foodservice Distr', 'Stephaine Vinning', '3717 Hamann Industrial Pky', 'San Francisco', 16, '94104', '415-767-6596', 'stephaine@cox.net'),
(30, 'Anchorage Museum Of Hist & Art', 'Nelida Sawchuk', '3 State Route 35 S', 'Paramus', 48, '7652', '201-971-1638', 'nelida@gmail.com'),
(31, 'Haber, George D Md', 'Marguerita Hiatt', '82 N Highway 67', 'Oakley', 26, '94561', '925-634-7158', 'marguerita.hiatt@gmail.com'),
(32, 'Royal Pontiac Olds Inc', 'Carmela Cookey', '9 Murfreesboro Rd', 'Chicago', 29, '60623', '773-494-4195', 'ccookey@cookey.org'),
(33, 'Leonards Antiques Inc', 'Junita Brideau', '6 S Broadway St', 'Cedar Grove', 1, '7009', '973-943-3423', 'jbrideau@aol.com'),
(34, 'Meca', 'Claribel Varriano', '6 Harry L Dr #6327', 'Perrysburg', 41, '43551', '419-544-4900', 'claribel_varriano@cox.net'),
(35, 'Nercon Engineering & Mfg Inc', 'Benton Skursky', '47939 Porter Ave', 'Gardena', 13, '90248', '310-579-2907', 'benton.skursky@aol.com'),
(36, 'Replica I', 'Hillary Skulski', '9 Wales Rd Ne #914', 'Homosassa', 14, '34448', '352-242-2570', 'hillary.skulski@aol.com'),
(37, '20 20 Printing Inc', 'Merilyn Bayless', '195 13n N', 'Santa Clara', 16, '95054', '408-758-5015', 'merilyn_bayless@cox.net'),
(38, 'Publishers Group West', 'Teri Ennaco', '99 Tank Farm Rd', 'Hazleton', 10, '18201', '570-889-5187', 'tennaco@gmail.com'),
(39, 'Nischwitz, Jeffrey L Esq', 'Merlyn Lawler', '4671 Alemany Blvd', 'Jersey City', 24, '7304', '201-588-7810', 'merlyn_lawler@hotmail.com'),
(40, 'Payne Blades & Wellborn Pa', 'Georgene Montezuma', '98 University Dr', 'San Ramon', 36, '94583', '925-615-5185', 'gmontezuma@cox.net'),
(41, 'Coldwell Bnkr Wright Real Est', 'Jettie Mconnell', '50 E Wacker Dr', 'Bridgewater', 43, '8807', '908-802-3564', 'jmconnell@hotmail.com'),
(42, 'Computer Repair Service', 'Lemuel Latzke', '70 Euclid Ave #722', 'Bohemia', 23, '11716', '631-748-6479', 'lemuel.latzke@gmail.com'),
(43, 'Fleetwood Building Block Inc', 'Melodie Knipp', '326 E Main St #6496', 'Thousand Oaks', 1, '91362', '805-690-1682', 'mknipp@gmail.com'),
(44, 'Colts Neck Medical Assocs Inc', 'Candida Corbley', '406 Main St', 'Somerville', 23, '8876', '908-275-8357', 'candida_corbley@hotmail.com'),
(45, 'New England Taxidermy', 'Karan Karpin', '3 Elmwood Dr', 'Beaverton', 17, '97005', '503-940-8327', 'karan_karpin@gmail.com'),
(46, 'Ludcke, George O Esq', 'Andra Scheyer', '9 Church St', 'Salem', 41, '97302', '503-516-2189', 'andra@gmail.com'),
(47, 'Mccorkle, Tom S Esq', 'Felicidad Poullion', '9939 N 14th St', 'Riverton', 28, '8077', '856-305-9731', 'fpoullion@poullion.com'),
(48, 'Eagle Software Inc', 'Belen Strassner', '5384 Southwyck Blvd', 'Douglasville', 48, '30135', '770-507-8791', 'belen_strassner@aol.com'),
(49, 'Juvenile & Adult Super', 'Gracia Melnyk', '97 Airport Loop Dr', 'Jacksonville', 18, '32216', '904-235-3633', 'gracia@melnyk.com'),
(50, 'Perez, Joseph J Esq', 'Jolanda Hanafan', '37855 Nolan Rd', 'Bangor', 48, '4401', '207-458-9196', 'jhanafan@gmail.com')



INSERT INTO TEmployees VALUES
(1, 'Barrett', 'Toyama'),
(2, 'Helga', 'Fredicks'),
(3, 'Ashlyn', 'Pinilla'),
(4, 'Fausto', 'Agramonte'),
(5, 'Ronny', 'Caiafa'),
(6, 'Marge', 'Limmel'),
(7, 'Norah', 'Waymire'),
(8, 'Aliza', 'Baltimore'),
(9, 'Mozell', 'Pelkowski'),
(10, 'Viola', 'Bitsuie'),
(11, 'Franklyn', 'Emard'),
(12, 'Willodean', 'Konopacki'),
(13, 'Beckie', 'Silvestrini'),
(14, 'Rebecka', 'Gesick'),
(15, 'Frederica', 'Blunk')

INSERT INTO TParts VALUES
(1,48, 'SN08242', 'Part 001',11,83.42,133.472,11),
(2,13, 'SN03836', 'Part 002',0,55.04,88.064,7),
(3,7, 'SN01418', 'Part 003',9,85.64,137.024,7),
(4,15, 'SN0260', 'Part 004',58,54.33,86.928,19),
(5,9, 'SN07948', 'Part 005',69,6.35,10.16,14),
(6,20, 'SN06987', 'Part 006',53,1.88,3.008,17),
(7,33, 'SN02196', 'Part 007',98,37.53,60.048,18),
(8,49, 'SN01038', 'Part 008',9,61.76,98.816,12),
(9,35, 'SN07918', 'Part 009',24,76.02,121.632,13),
(10,43, 'SN06210', 'Part 010',13,37.33,59.728,9),
(11,18, 'SN04580', 'Part 011',93,18.38,29.408,3),
(12,33, 'SN01102', 'Part 012',56,20.35,32.56,6),
(13,13, 'SN09042', 'Part 013',73,34.18,54.688,7),
(14,43, 'SN01544', 'Part 014',42,96.16,153.856,9),
(15,42, 'SN03825', 'Part 015',15,74.58,119.328,10),
(16,18, 'SN08566', 'Part 016',41,87.64,140.224,7),
(17,23, 'SN0621', 'Part 017',92,49.55,79.28,12),
(18,23, 'SN06456', 'Part 018',40,55.58,88.928,13),
(19,13, 'SN08936', 'Part 019',20,71.82,114.912,5),
(20,41, 'SN06039', 'Part 020',97,54.97,87.952,1)


INSERT INTO TPaymentTypes VALUES
 (1, 'Cash')
,(2, 'Credit / Debit ')
,(3, 'Check')
,(4, 'Bank Transfer')



GO

CREATE VIEW vCustomers
AS
SELECT
	 TC.intCustomerID
	,TC.strFirstName
	,TC.strLastName
	,TC.strAddress
	,TC.strCity
	,TS.strState
	,TC.strZip
	,TC.strPhoneNumber
	,TC.strEmail
FROM
	TCustomers AS TC
	,TStates AS TS
WHERE
	TC.intStateID= TS.intStateID
GO



SELECT * FROM vCustomers

GO


GO

CREATE VIEW vParts
AS
SELECT
	intPartID
	,intVendorID
	,strSerialNumber
	,strPartDesc
	,intQuantity
	,decUnitPurchaseCost
	,decUniteSaleCost
	,intAmountSold
FROM
	TParts AS TP
GO


SELECT * FROM vParts

GO