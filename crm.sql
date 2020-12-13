-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbCapstone; -- Get out of the master database
SET NOCOUNT ON; -- Report only errors

-- --------------------------------------------------------------------------------
-- Drop Tables
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'TInvoicePayments' )				IS NOT NULL DROP TABLE TInvoicePayments
IF OBJECT_ID( 'TPartsOrders' )					IS NOT NULL DROP TABLE TPartsOrders
IF OBJECT_ID( 'TBankAccounts' )					IS NOT NULL DROP TABLE TBankAccounts
IF OBJECT_ID( 'TBankAccountTypes' )				IS NOT NULL DROP TABLE TBankAccountTypes
IF OBJECT_ID( 'TCustomerPaymentTypes' )			IS NOT NULL DROP TABLE TCustomerPaymentTypes
IF OBJECT_ID( 'TCreditCards' )					IS NOT NULL DROP TABLE TCreditCards
IF OBJECT_ID( 'TCreditCardTypes' )				IS NOT NULL DROP TABLE TCreditCardTypes
IF OBJECT_ID( 'TCreditCardCompanies' )			IS NOT NULL DROP TABLE TCreditCardCompanies
IF OBJECT_ID( 'TJobServices' )					IS NOT NULL DROP TABLE TJobServices
IF OBJECT_ID( 'TInvoices' )						IS NOT NULL DROP TABLE TInvoices
IF OBJECT_ID( 'TJobEmployees' )					IS NOT NULL DROP TABLE TJobEmployees
IF OBJECT_ID( 'TJobParts' )						IS NOT NULL DROP TABLE TJobParts
IF OBJECT_ID( 'TParts' )						IS NOT NULL DROP TABLE TParts
IF OBJECT_ID( 'TVendors' )						IS NOT NULL DROP TABLE TVendors
IF OBJECT_ID( 'TReviews' )						IS NOT NULL DROP TABLE TReviews
IF OBJECT_ID( 'TJobs' )							IS NOT NULL DROP TABLE TJobs
IF OBJECT_ID( 'TEmployees' )					IS NOT NULL DROP TABLE TEmployees
IF OBJECT_ID( 'TJobRecords' )					IS NOT NULL DROP TABLE TJobRecords
IF OBJECT_ID( 'TStatuses' )						IS NOT NULL DROP TABLE TStatuses
IF OBJECT_ID( 'TServices' )						IS NOT NULL DROP TABLE TServices
IF OBJECT_ID( 'TPaymentTypes' )					IS NOT NULL DROP TABLE TPaymentTypes
IF OBJECT_ID( 'TCustomers' )					IS NOT NULL DROP TABLE TCustomers
IF OBJECT_ID( 'TCities' )						IS NOT NULL DROP TABLE TCities
IF OBJECT_ID( 'TStates' )						IS NOT NULL DROP TABLE TStates
IF OBJECT_ID( 'TUserLogin' )					IS NOT NULL DROP TABLE TUserLogin
IF OBJECT_ID( 'TFinances' )						IS NOT NULL DROP TABLE TFinances
IF OBJECT_ID( 'TMonths' )						IS NOT NULL DROP TABLE TMonths
IF OBJECT_ID( 'TYears' )						IS NOT NULL DROP TABLE TYears


-- --------------------------------------------------------------------------------
-- Drop Views
-- --------------------------------------------------------------------------------
IF OBJECT_ID( 'vCustomers' )					IS NOT NULL DROP VIEW vCustomers
IF OBJECT_ID( 'VParts' )						IS NOT NULL DROP VIEW vParts
IF OBJECT_ID( 'vBankAccount' )					IS NOT NULL DROP VIEW vBankAccount
IF OBJECT_ID( 'vVendors' )						IS NOT NULL DROP VIEW vVendors
IF OBJECT_ID( 'vMonthAndYear' )					IS NOT NULL DROP VIEW vMonthAndYear
IF OBJECT_ID( 'vMonthlyFinances' )				IS NOT NULL DROP VIEW vMonthlyFinances
IF OBJECT_ID( 'vYTDFinances' )					IS NOT NULL DROP VIEW vYTDFinances
IF OBJECT_ID( 'vJobRecordCustomers' )			IS NOT NULL DROP VIEW vJobRecordCustomers
IF OBJECT_ID( 'vJobRecords' )					IS NOT NULL DROP VIEW vJobRecords
IF OBJECT_ID( 'vJobRecordNumber' )				IS NOT NULL DROP VIEW vJobRecordNumber
IF OBJECT_ID( 'vJobRecordsSearch' )				IS NOT NULL DROP VIEW vJobRecordsSearch
IF OBJECT_ID( 'vCustomersWithInvoices' )		IS NOT NULL DROP VIEW vCustomersWithInvoices
IF OBJECT_ID( 'vJobRecordStatus' )				IS NOT NULL DROP VIEW vJobRecordStatus
IF OBJECT_ID( 'vJobAndCustomerInfo' )			IS NOT NULL DROP VIEW vJobAndCustomerInfo
IF OBJECT_ID( 'vJobsAndNoInvoice' )				IS NOT NULL DROP VIEW vJobsAndNoInvoice
IF OBJECT_ID( 'vJobsWithoutInvoices' )			IS NOT NULL DROP VIEW vJobsWithoutInvoices
IF OBJECT_ID( 'vMonthlyRevenue' )				IS NOT NULL DROP VIEW vMonthlyRevenue
IF OBJECT_ID( 'vEmployeesOnJob' )				IS NOT NULL DROP VIEW vEmployeesOnJob
IF OBJECT_ID( 'vCustomerInvoices' )				IS NOT NULL DROP VIEW vCustomerInvoices
IF OBJECT_ID( 'vPrintableInvoice' )				IS NOT NULL DROP VIEW vPrintableInvoice
IF OBJECT_ID( 'vPartsOrderedCost' )				IS NOT NULL DROP VIEW vPartsOrderedCost
IF OBJECT_ID( 'vPartOrders' )					IS NOT NULL DROP VIEW vPartOrders
IF OBJECT_ID( 'vEmployeeNames' )				IS NOT NULL DROP VIEW vEmployeeNames


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
	,strVendorName		VARCHAR(50)		NOT NULL
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
	,intJobRecordID			INTEGER			NOT NULL
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


CREATE TABLE TParts
(
	 intPartID					INTEGER			NOT NULL
	,intVendorID				INTEGER			NOT NULL	
	,strSerialNumber			VARCHAR(50)		NOT NULL
	,strPartName				VARCHAR(100)	NOT NULL
	,strPartDesc				VARCHAR(500)	NOT NULL
	,intQuantityBackordered		INTEGER			NOT NULL
	,intQuantity				INTEGER			NOT NULL
	,decUnitPurchaseCost		DECIMAL(7,2)	NOT NULL
	,decUnitSaleCost			DECIMAL(7,2)	NOT NULL
	,PNumber AS CASE len(intpartID)
		when 1 then 'PO-'+'00000'+CONVERT(varchar, intPartID)
		when 2 then 'PO-'+'0000'+CONVERT(varchar, intPartID)
		when 3 then 'PO-'+'000'+CONVERT(varchar, intPartID)
		when 4 then 'PO-'+'00'+CONVERT(varchar, intPartID)
		when 5 then 'PO-'+'0'+CONVERT(varchar, intPartID)
		else'PO-'+CONVERT(varchar, intPartID)
		end
	,CONSTRAINT TParts_PK PRIMARY KEY ( intPartID )
)

CREATE TABLE TJobParts
(
	 intJobPartID			INTEGER			NOT NULL
	,intJobRecordID			INTEGER			NOT NULL
	,intPartID				INTEGER			NOT NULL
	,intPartQuantity		INTEGER			NOT NULL
	,CONSTRAINT TJobParts_PK PRIMARY KEY ( intJobPartID )
)

CREATE TABLE TPartsOrders
(
	 intPartOrderedID		INTEGER			NOT NULL
	,intPartID				INTEGER			NOT NULL
	,dtDateOrdered			DATETIME		NOT NULL
	,dtDateArrived			DATETIME		NOT NULL
	,blnArrived				BIT				NOT NULL
	,intQuantity			INTEGER			NOT NULL
	,decUnitPurchaseCost	DECIMAL(7,2)	NOT NULL
	,PONumber AS CASE len(intPartOrderedID)
		when 1 then 'PO-'+'00000'+CONVERT(varchar, intPartID)
		when 2 then 'PO-'+'0000'+CONVERT(varchar, intPartID)
		when 3 then 'PO-'+'000'+CONVERT(varchar, intPartID)
		when 4 then 'PO-'+'00'+CONVERT(varchar, intPartID)
		when 5 then 'PO-'+'0'+CONVERT(varchar, intPartID)
		else'PO-'+CONVERT(varchar, intPartID)
		end
	,CONSTRAINT TPartsOrders_PK PRIMARY KEY ( intPartOrderedID )
)

CREATE TABLE TJobEmployees
(
	 intJobEmployeeID		INTEGER			NOT NULL
	,intJobRecordID			INTEGER			NOT NULL
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
	,intJobRecordID			INTEGER			NOT NULL
	,decServiceCost			DECIMAL(7,2)	NOT NULL
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
	,intJobRecordID			INTEGER			NOT NULL
	,dtDateDue				DATETIME		NOT NULL
	,decJobCost				DECIMAL(7,2)	NOT NULL
	,decAmountPaid			DECIMAL(7,2)	NOT NULL
	,CIN AS CASE len(intInvoiceID)
		when 1 then 'CIN-'+'00000'+CONVERT(varchar, intInvoiceID)
		when 2 then 'CIN-'+'0000'+CONVERT(varchar, intInvoiceID)
		when 3 then 'CIN-'+'000'+CONVERT(varchar, intInvoiceID)
		when 4 then 'CIN-'+'00'+CONVERT(varchar, intInvoiceID)
		when 5 then 'CIN-'+'0'+CONVERT(varchar, intInvoiceID)
		else'CIN-'+CONVERT(varchar, intInvoiceID)
		end
	,CONSTRAINT TInvoices_PK PRIMARY KEY ( intInvoiceID)
)

CREATE TABLE TInvoicePayments
(
	 intInvoicePaymentID		INTEGER			NOT NULL
	,intInvoiceID				INTEGER			NOT NULL
	,decPaymentAmount			DECIMAL(7,2)	NOT NULL
	,dtDateOfPayment			DATETIME		NOT NULL
	CONSTRAINT TInvoicePayments_PK PRIMARY KEY ( intInvoicePaymentID )
)

CREATE TABLE TPaymentTypes
(
	 intPaymentTypeID		INTEGER			NOT NULL
	,strServiceDesc			VARCHAR(50)		NOT NULL
	,CONSTRAINT	TPaymentTypes_PK PRIMARY KEY ( intPaymentTypeID )
)

CREATE TABLE TCreditCardTypes
(
	 intCreditCardTypeID	INTEGER			NOT NULL
	,strCardTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TCreditCardTypes_PK PRIMARY KEY ( intCreditCardTypeID )
)

CREATE TABLE TCreditCardCompanies
(
	 intCardCompanyID		INTEGER			NOT NULL
	,strCardCompanyDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TCreditCardCompanies_PK PRIMARY KEY ( intCardCompanyID )
)

CREATE TABLE TCreditCards
(
	 intCreditCardID		INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,strCardholderName		VARCHAR(50)		NOT NULL
	,strCardNumber			VARCHAR(50)		NOT NULL
	,strExpiration			VARCHAR(5)		NOT NULL
	,strCVV					VARCHAR(3)		NOT NULL
	,intCardCompanyID		INTEGER			NOT NULL
	,intCreditCardTypeID	INTEGER			NOT NULL
	,CONSTRAINT TCreditCards_PK PRIMARY KEY ( intCreditCardID )
)

CREATE TABLE TBankAccountTypes
(
	 intBankAccountTypeID	INTEGER			NOT NULL
	,strAccountTypeDesc		VARCHAR(50)		NOT NULL
	,CONSTRAINT TBankAccountTypes_PK PRIMARY KEY ( intBankAccountTypeID )
)

CREATE TABLE TBankAccounts
(
	 intBankAccountID		INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,strRoutingNumber		VARCHAR(50)		NOT NULL
	,strAccountNumber		VARCHAR(50)		NOT NULL
	,intBankAccountTypeID	INTEGER			NOT NULL
	,strAccountName			VARCHAR(50)		NOT NULL
	,CONSTRAINT TBankAccounts_PK PRIMARY KEY (intBankAccountID)
)

CREATE TABLE TCustomerPaymentTypes
(
	 intCustomerPaymentID	INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,intPaymentTypeID		INTEGER			NOT NULL
	,CONSTRAINT TCustomerPaymentTypes_PK PRIMARY KEY ( intCustomerPaymentID )
)

CREATE TABLE TUserLogin
(
	 intUserLoginID			INTEGER			NOT NULL
	,strUsername			VARCHAR(20)		NOT NULL
	,strPassword			VARCHAR(20)		NOT NULL
	,CONSTRAINT TUserLogin_PK PRIMARY KEY ( intUserLoginID )
)

CREATE TABLE TMonths
(
	 intMonthID				INTEGER			NOT NULL
	,strMonth				VARCHAR(50)		NOT NULL
	,CONSTRAINT	TMonths_PK PRIMARY KEY ( intMonthID )
)

CREATE TABLE TYears
(
	 intYearID				INTEGER			NOT NULL
	,strYear				VARCHAR(50)		NOT NULL
	,CONSTRAINT	TYears_PK PRIMARY KEY ( intYearID )
)

CREATE TABLE TFinances
(
	 intFinanceID			INTEGER			NOT NULL
	,intMonthID				INTEGER			NOT NULL
	,intYearID				INTEGER			NOT NULL
	,decPayrollCost			DECIMAL(7,2)	NOT NULL
	,decInsuranceCost		DECIMAL(7,2)	NOT NULL
	,decVehicleCost			DECIMAL(7,2)	NOT NULL
	,decFuelCost			DECIMAL(7,2)	NOT NULL
	,decShopRental			DECIMAL(7,2)	NOT NULL
	,decUtilitiesCost		DECIMAL(7,2)	NOT NULL
	,decOtherCost			DECIMAL(7,2)	NOT NULL
	,CONSTRAINT TFinances_PK PRIMARY KEY (intFinanceID)
)

CREATE TABLE TJobRecords
(
	 intJobRecordID			INTEGER			NOT NULL
	,dtStartDate			DATETIME		NOT NULL
	,dtEndDate				DATETIME		NOT NULL
	,strJobDesc				VARCHAR(500)	NOT NULL
	,intStatusID			INTEGER			NOT NULL
	,intCustomerID			INTEGER			NOT NULL
	,JobNumber AS CASE len(intJobRecordID)
		when 1 then '00000'+CONVERT(varchar, intJobRecordID)
		when 2 then '0000'+CONVERT(varchar, intJobRecordID)
		when 3 then '000'+CONVERT(varchar, intJobRecordID)
		when 4 then '00'+CONVERT(varchar, intJobRecordID)
		when 5 then '0'+CONVERT(varchar, intJobRecordID)
		else'PO-'+CONVERT(varchar, intJobRecordID)
		end
	,CONSTRAINT TJobRecords_PK PRIMARY KEY (intJobRecordID)
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
-- 8	TReviews						TJobs						intJobRecordID
-- 9	TParts							TVendors					intVendorID
-- 10	TJobParts						TJobs						intJobRecordID
-- 11	TJobParts						TParts						intPartID
-- 12	TJobEmployees					TJobs						intJobRecordID
-- 13	TJobEmployees					TEmployees					intEmployeeID
-- 14	TJobServices					TServices					intServiceID
-- 15	TInvoices						TCustomers					intCustomerID
-- 16	TInvoices						TJobRecords					intJobRecordID
-- 17	TInvoices						TPaymentTypes				intPaymentTypeID
-- 18	TCustomerPaymentTypes			TCustomers					intCustomerID
-- 19	TCreditCards					TCreditCardTypes			intCreditCardTypeID
-- 20	TCreditCards					TCreditCardCompanies		intCardCompanyID
-- 21	TCreditCards					TCustomers					intCustomerID
-- 22	TBankAccounts					TBankAccountTypes			intBankAccountTypeID
-- 23	TBankAccounts					TCustomers					intCustomerID
-- 24	TFinances						TMonths						intMonthID
-- 25	TFinances						TYears						intYearID
-- 26	TJobRecords						TCustomers					intCustomerID
-- 27	TJobRecords						TStatuses					intStatusID
-- 28	TJobServices					TInvoices					intInvoiceID
-- 29	TInvoicePayments				TInvoices					intInvoiceID
-- 30	TPartsOrders					TParts						intPartID

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

---- 5
--ALTER TABLE TJobs ADD CONSTRAINT TJobs_TCustomers_FK
--FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

---- 6
--ALTER TABLE TJobs ADD CONSTRAINT TJobs_TStatuses_FK
--FOREIGN KEY ( intStatusID ) REFERENCES TStatuses ( intStatusID )

-- 7
ALTER TABLE TReviews ADD CONSTRAINT TReviews_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 8
ALTER TABLE TReviews ADD CONSTRAINT TReviews_TJobs_FK
FOREIGN KEY ( intJobRecordID ) REFERENCES TJobRecords ( intJobRecordID )

-- 9
ALTER TABLE TParts ADD CONSTRAINT TParts_TVendors_FK
FOREIGN KEY ( intVendorID ) REFERENCES TVendors ( intVendorID )

-- 10
ALTER TABLE TJobParts ADD CONSTRAINT TJobParts_TJobs_FK
FOREIGN KEY ( intJobRecordID ) REFERENCES TJobRecords ( intJobRecordID )

-- 11
ALTER TABLE TJobParts ADD CONSTRAINT TJobParts_TParts_FK
FOREIGN KEY ( intPartID ) REFERENCES TParts ( intPartID )

-- 12
ALTER TABLE TJobEmployees ADD CONSTRAINT TJobEmployees_TJobs_FK
FOREIGN KEY ( intJobRecordID ) REFERENCES TJobRecords ( intJobRecordID )

-- 13
ALTER TABLE TJobEmployees ADD CONSTRAINT TJobEmployees_TEmployees_FK
FOREIGN KEY ( intEmployeeID ) REFERENCES TEmployees ( intEmployeeID )

-- 14
ALTER TABLE TJobServices ADD CONSTRAINT TJobServices_TServices_FK
FOREIGN KEY ( intServiceID ) REFERENCES TServices ( intServiceID )

-- 15
--ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TCustomers_FK
--FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 16
ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TJobRecords_FK
FOREIGN KEY ( intJobRecordID ) REFERENCES TJobRecords ( intJobRecordID )

---- 17
--ALTER TABLE	TInvoices ADD CONSTRAINT TInvoices_TPaymentTypes_FK
--FOREIGN KEY ( intPaymentTypeID ) REFERENCES TPaymentTypes ( intPaymentTypeID )

-- 18
ALTER TABLE TCustomerPaymentTypes ADD CONSTRAINT TCustomerPayments_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 19
ALTER TABLE TCreditCards ADD CONSTRAINT TCreditCards_TCreditCardTypes_FK
FOREIGN KEY ( intCreditCardTypeID ) REFERENCES TCreditCardTypes ( intCreditCardTypeID )

-- 20
ALTER TABLE TCreditCards ADD CONSTRAINT TCreditCards_TCreditCardCompanies_FK
FOREIGN KEY ( intCardCompanyID ) REFERENCES TCreditCardCompanies ( intCardCompanyID )

-- 21
ALTER TABLE TCreditCards ADD CONSTRAINT TCreditCards_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 22
ALTER TABLE TBankAccounts ADD CONSTRAINT TBankAccounts_TBankAccountTypes_FK
FOREIGN KEY ( intBankAccountTypeID ) REFERENCES TBankAccountTypes ( intBankAccountTypeID )

-- 23
ALTER TABLE TBankAccounts ADD CONSTRAINT TBankAccounts_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 24
ALTER TABLE TFinances ADD CONSTRAINT TFinances_TMonths_FK
FOREIGN KEY ( intMonthID ) REFERENCES TMonths ( intMonthID )

-- 25
ALTER TABLE TFinances ADD CONSTRAINT TFinances_TYears_FK
FOREIGN KEY ( intYearID ) REFERENCES TYears ( intYearID )

-- 26
ALTER TABLE TJobRecords ADD CONSTRAINT TJobRecords_TCustomers_FK
FOREIGN KEY ( intCustomerID ) REFERENCES TCustomers ( intCustomerID )

-- 27
ALTER TABLE TJobRecords ADD CONSTRAINT TJobRecords_TStatuses_FK
FOREIGN KEY ( intStatusID ) REFERENCES TStatuses ( intStatusID )

-- 28
--ALTER TABLE TJobServices ADD CONSTRAINT TJobServices_TInvoices_FK
--FOREIGN KEY ( intInvoiceID ) REFERENCES TInvoices ( intInvoiceID )

-- 29
ALTER TABLE TInvoicePayments ADD CONSTRAINT TInvoicePayments_TInvoices_FK
FOREIGN KEY ( intInvoiceID ) REFERENCES TInvoices ( intInvoiceID )

-- 30
ALTER TABLE TPartsOrders ADD CONSTRAINT TPartsOrders_TParts_FK
FOREIGN KEY ( intPartID ) REFERENCES TParts ( intPartID )

---- --------------------------------------------------------------------------------
---- Add Necessary Data
---- --------------------------------------------------------------------------------

INSERT INTO TStates values 
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
-- intVendorID, strSerialNumber, strPartName, strDesc, intQuantityBackordered, intQuantity, decUnitPurchaseCost, decUnitSaleCost
(1,48, 'SN08242', 'Chlorinator Model 430 Feeder', 'Replacement parts for liquid chemical pumps, and chlorine tablet feeders. Frog ground model', 0, 11,83.42,133.472),
(2,13, 'SN03836', 'Chlorinator Model 600 Feeder', 'Replacement parts for liquid chemical pumps, and chlorine tablet feeders. Frog ground model', 0, 0,55.04,88.064),
(3,7, 'SN01418', 'Chlorine Cells', 'Replacement parts for chlorine tablet feeders.', 0, 9,85.64,137.024),
(4,15, 'SN0260', 'AquaSwitch & Pool Control', 'Replacement parts for pool system controller.',  0, 18,54.33,86.928),
(5,9, 'SN07948', 'EOS Personalized Automated Control', 'Replacement parts for pool system controller.', 0, 69,6.35,10.16),
(6,20, 'SN06987', 'PVC pipe connector', 'Connector for fitting pipes together.', 0, 53,1.88,3.008),
(7,33, 'SN02196', 'Pro Logic', 'Replacement parts for pool system controllers.', 0, 8,37.53,60.048),
(8,49, 'SN01038', 'CAT Control Replacement Parts', 'Replacement parts for pool system controllers - chemical controllers, and pool equipment controls.', 0, 9,61.76,98.816),
(9,35, 'SN07918', 'CPS Model 520-1820-PG', 'Pool heater part.', 0, 4,76.02,121.632),
(10,43, 'SN06210', 'Heatmaster HM2 model 150-400', 'Pool heater part.', 0, 13,37.33,59.728),
(11,18, 'SN04580', 'Micro-Clean', 'Filtration kit.', 0, 23,18.38,29.408),
(12,33, 'SN01102', 'C2000 Duralon', 'Filtration kit.', 0, 16,20.35,32.56),
(13,13, 'SN09042', 'Avalanche AV60', 'Stainless steel filtration kit.', 0, 73,34.18,54.688),
(14,43, 'SN01544', 'Swimquip Underwater Pool Lights', 'Underwater pool lighting kit.', 0, 42,96.16,153.856),
(15,42, 'SN03825', 'SP-500 Sealed Beam', 'Lighting kit.', 0, 15,74.58,119.328),
(16,18, 'SN08566', 'SP-1600X Super Pump', 'Water pump kit.', 0, 41,87.64,140.224),
(17,23, 'SN0621', 'Sp-4000 Series NorthStar', 'Plastic water pump.', 0, 92,49.55,79.28),
(18,23, 'SN06456', 'Magnum Force Pump', 'Water pump.', 0, 40,55.58,88.928),
(19,13, 'SN08936', 'Intermatic Timer Motors', 'Timer for water pumping or lights', 4, 6,71.82,114.912),
(20,41, 'SN06039', 'Century A.O. Smith Motor', 'Water pump motor.', 2, 10,54.97,87.952)

INSERT INTO TPartsOrders VALUES
--intPartID, dateOrdered, dateArrived, blnArrived, intQuantity, decUnitPurchaseCost
(1, 1, '6-01-2020', '6-08-2020', 1, 15, 1251.30)
,(2, 2, '6-05-2020', '6-12-2020', 1, 10, 550.40)
,(3, 3, '6-18-2020', '6-26-2020', 1, 10, 856.40)
,(4, 4, '7-05-2020', '7-12-2020', 1, 20, 1086.60)
,(5, 5, '7-09-2020', '7-17-2020', 1, 100, 635.00)
,(6, 6, '7-16-2020', '7-22-2020', 1, 90, 169.20)
,(7, 7, '8-06-2020', '8-12-2020', 1, 10, 375.30)
,(8, 8, '8-10-2020', '8-17-2020', 1, 10, 617.60)
,(9, 9, '8-14-2020', '8-22-2020', 1, 6, 456.12)
,(10, 10, '9-08-2020', '9-15-2020', 1, 15, 559.95)
,(11, 11, '9-12-2020', '9-19-2020', 1, 30, 551.40)
,(12, 12, '9-17-2020', '9-23-2020', 1, 30, 610.50)
,(13, 13, '10-06-2020', '10-12-2020', 1, 8, 273.44)
,(14, 14, '10-10-2020', '10-17-2020', 1, 5, 480.80)
,(15, 15, '10-14-2020', '10-22-2020', 1, 3, 223.74)
,(16, 16, '11-03-2020', '11-09-2020', 1, 4, 350.60)
,(17, 17, '11-09-2020', '11-15-2020', 1, 10, 495.50)
,(18, 18, '11-20-2020', '11-28-2020', 1, 6, 456.12)
,(19, 19, '12-06-2020', '12-12-2020', 0, 4, 287.28)
,(20, 20, '12-10-2020', '12-17-2020', 0, 2, 109.94)

INSERT INTO TPaymentTypes VALUES
(1, 'Cash'),
(2, 'Credit / Debit '),
(3, 'Check'),
(4, 'Bank Transfer')

INSERT INTO TCreditCardTypes VALUES
(1, 'Debit'),
(2, 'Credit')

INSERT INTO TCreditCardCompanies VALUES
(1, 'American Express'),
(2, 'Mastercard'),
(3, 'Visa')

INSERT INTO TBankAccountTypes VALUES
(1, 'Checking'),
(2, 'Savings')

INSERT INTO TUserLogin VALUES
(1, 'admin', 'admin'),
(2, 'test', 'test')

INSERT INTO TMonths VALUES
(1, 'January'),
(2, 'February'),
(3, 'March'),
(4, 'April'),
(5, 'May'),
(6, 'June'),
(7, 'July'),
(8, 'August'),
(9, 'September'),
(10, 'October'),
(11, 'November'),
(12, 'December')

INSERT INTO TYears VALUES
(1, '2020')

INSERT INTO TFinances VALUES
-- intMonthID, intYearID, decPayrollCost, decInsuranceCost, decVehicleCost, decFuelCost, decShopRental, decUtilities, decOtherCost
(1, 6, 1, 3451.86, 1072.64, 61.96, 289.57, 1245.72, 703.15, 176.32),
(2, 7, 1, 3524.34, 1072.64, 96.21, 305.21, 1245.72, 743.25, 115.74),
(3, 8, 1, 3415.35, 1072.64, 81.58, 293.18, 1245.72, 752.73, 183.25),
(4, 9, 1, 3921.25, 1072.64, 153.25, 252.56, 1245.72, 726.23, 91.53),
(5, 10, 1, 2656.85, 1072.64, 78.83, 173.25, 1245.72, 731.52, 99.25),
(6, 11, 1, 2015.32, 1072.64, 135.64, 91.75, 1245.72, 782.64, 116.75)

INSERT INTO TStatuses VALUES 
(1, 'Scheduled'),
(2, 'In Progress'),
(3, 'Completed')

INSERT INTO TServices VALUES 
 (1, 'Liner Installation')
,(2, 'Water Testing')
,(3, 'Leak Detection')
,(4, 'Vacuuming')
,(5, 'Skimming')
,(6, 'Chemicals Added')
,(7, 'Filter Backwashed')

INSERT INTO TJobRecords VALUES
-- StartDate, EndDate, Description, Status, CustomerID
(1, '6-01-2020', '6-03-2020', 'Maintanence performed. Cleaned pool', 3, 1)
,(2, '6-02-2020', '6-10-2020', 'Pool Installation and consultaion.', 3, 2)
,(3, '6-04-2020', '6-07-2020', 'Water testing and leak detection performed', 3, 3)
,(4, '6-09-2020', '6-10-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 4)
,(5, '6-11-2020', '6-13-2020', 'Water testing, pool skimmed, chemicals added', 3, 5)
,(6, '6-13-2020', '6-15-2020', 'Vacuumed, chemicals added, leak detection', 3, 6)
,(7, '6-15-2020', '6-16-2020', 'Water testing', 3, 7)
,(8, '6-16-2020', '6-17-2020', 'Skimmed, chemicals added', 3, 8)
,(9, '6-18-2020', '6-20-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 9)
,(10, '6-20-2020', '6-21-2020', 'Maintanence of pool.', 3, 10)
,(11, '6-21-2020', '6-23-2020', 'Maintanence performed. Cleaned pool', 3, 11)
,(12, '6-22-2020', '6-29-2020', 'Pool Installation and consultaion.', 3, 12)
,(13, '6-24-2020', '6-26-2020', 'Water testing and leak detection performed', 3, 13)
,(14, '6-27-2020', '6-28-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 14)
,(15, '6-28-2020', '6-29-2020', 'Water testing, pool skimmed, chemicals added', 3, 15)
,(16, '7-01-2020', '7-02-2020', 'Vacuumed, chemicals added, leak detection', 3, 16)
,(17, '7-02-2020', '7-03-2020', 'Water testing', 3, 17)
,(18, '7-03-2020', '7-05-2020', 'Skimmed, chemicals added', 3, 18)
,(19, '7-05-2020', '7-08-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 19)
,(20, '7-07-2020', '7-08-2020', 'Maintanence of pool.', 3, 20)
,(21, '7-09-2020', '7-10-2020', 'Maintanence performed. Cleaned pool', 3, 21)
,(22, '7-11-2020', '7-12-2020', 'Pool Installation and consultaion.', 3, 22)
,(23, '7-13-2020', '7-15-2020', 'Water testing and leak detection performed', 3, 23)
,(24, '7-15-2020', '7-18-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 24)
,(25, '7-17-2020', '7-19-2020', 'Water testing, pool skimmed, chemicals added', 3, 25)
,(26, '7-20-2020', '7-21-2020', 'Vacuumed, chemicals added, leak detection', 3, 26)
,(27, '7-21-2020', '7-22-2020', 'Water testing', 3, 27)
,(28, '7-22-2020', '7-24-2020', 'Skimmed, chemicals added', 3, 28)
,(29, '7-23-2020', '7-25-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 29)
,(30, '7-25-2020', '7-26-2020', 'Maintanence of pool.', 3, 30)
,(31, '7-26-2020', '7-27-2020', 'Maintanence performed. Cleaned pool', 3, 31)
,(32, '7-27-2020', '7-28-2020', 'Pool Installation and consultaion.', 3, 32)
,(33, '7-28-2020', '7-29-2020', 'Water testing and leak detection performed', 3, 33)
,(34, '7-29-2020', '7-30-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 34)
,(35, '7-30-2020', '7-31-2020', 'Water testing, pool skimmed, chemicals added', 3, 35)
,(36, '8-01-2020', '8-02-2020', 'Vacuumed, chemicals added, leak detection', 3, 36)
,(37, '8-02-2020', '8-03-2020', 'Water testing', 3, 37)
,(38, '8-03-2020', '8-05-2020', 'Skimmed, chemicals added', 3, 38)
,(39, '8-05-2020', '8-08-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 39)
,(40, '8-07-2020', '8-08-2020', 'Maintanence of pool.', 3, 40)
,(41, '8-09-2020', '8-10-2020', 'Maintanence performed. Cleaned pool', 3, 41)
,(42, '8-11-2020', '8-12-2020', 'Pool Installation and consultaion.', 3, 42)
,(43, '8-13-2020', '8-15-2020', 'Water testing and leak detection performed', 3, 43)
,(44, '8-15-2020', '8-18-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 44)
,(45, '8-17-2020', '8-19-2020', 'Water testing, pool skimmed, chemicals added', 3, 45)
,(46, '8-20-2020', '8-21-2020', 'Vacuumed, chemicals added, leak detection', 3, 46)
,(47, '8-21-2020', '8-22-2020', 'Water testing', 3, 47)
,(48, '8-22-2020', '8-24-2020', 'Skimmed, chemicals added', 3, 48)
,(49, '8-23-2020', '8-25-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 49)
,(50, '8-25-2020', '8-26-2020', 'Maintanence of pool.', 3, 50)
,(51, '8-26-2020', '8-27-2020', 'Maintanence performed. Cleaned pool', 3, 51)
,(52, '8-27-2020', '8-28-2020', 'Pool Installation and consultaion.', 3, 52)
,(53, '8-28-2020', '8-29-2020', 'Water testing and leak detection performed', 3, 53)
,(54, '8-29-2020', '8-30-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 54)
,(55, '8-30-2020', '8-31-2020', 'Water testing, pool skimmed, chemicals added', 3, 55)
,(56, '9-01-2020', '9-02-2020', 'Vacuumed, chemicals added, leak detection', 3, 56)
,(57, '9-02-2020', '9-03-2020', 'Water testing', 3, 57)
,(58, '9-03-2020', '9-05-2020', 'Skimmed, chemicals added', 3, 58)
,(59, '9-05-2020', '9-08-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 59)
,(60, '9-07-2020', '9-08-2020', 'Maintanence of pool.', 3, 60)
,(61, '9-09-2020', '9-10-2020', 'Maintanence performed. Cleaned pool', 3, 61)
,(62, '9-11-2020', '9-12-2020', 'Pool Installation and consultaion.', 3, 62)
,(63, '9-13-2020', '9-15-2020', 'Water testing and leak detection performed', 3, 63)
,(64, '9-15-2020', '9-18-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 64)
,(65, '9-17-2020', '9-19-2020', 'Water testing, pool skimmed, chemicals added', 3, 65)
,(66, '9-20-2020', '9-21-2020', 'Vacuumed, chemicals added, leak detection', 3, 66)
,(67, '9-21-2020', '9-22-2020', 'Water testing', 3, 67)
,(68, '9-22-2020', '9-24-2020', 'Skimmed, chemicals added', 3, 68)
,(69, '9-23-2020', '9-25-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 69)
,(70, '9-25-2020', '9-26-2020', 'Maintanence of pool.', 3, 70)
,(71, '10-01-2020', '10-03-2020', 'Maintanence performed. Cleaned pool', 3, 71)
,(72, '10-02-2020', '10-10-2020', 'Pool Installation and consultaion.', 3, 72)
,(73, '10-04-2020', '10-07-2020', 'Water testing and leak detection performed', 3, 73)
,(74, '10-09-2020', '10-10-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 74)
,(75, '10-11-2020', '10-13-2020', 'Water testing, pool skimmed, chemicals added', 3, 75)
,(76, '10-13-2020', '10-15-2020', 'Vacuumed, chemicals added, leak detection', 3, 76)
,(77, '10-15-2020', '10-16-2020', 'Water testing', 3, 77)
,(78, '10-16-2020', '10-17-2020', 'Skimmed, chemicals added', 3, 78)
,(79, '10-18-2020', '10-20-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 79)
,(80, '10-20-2020', '10-21-2020', 'Maintanence of pool.', 3, 80)
,(81, '10-21-2020', '10-23-2020', 'Maintanence performed. Cleaned pool', 3, 81)
,(82, '10-22-2020', '10-29-2020', 'Pool Installation and consultaion.', 3, 82)
,(83, '10-24-2020', '10-26-2020', 'Water testing and leak detection performed', 3, 83)
,(84, '10-27-2020', '10-28-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 84)
,(85, '10-28-2020', '10-29-2020', 'Water testing, pool skimmed, chemicals added', 3, 85)
,(86, '11-01-2020', '11-02-2020', 'Vacuumed, chemicals added, leak detection', 3, 86)
,(87, '11-02-2020', '11-03-2020', 'Water testing', 3, 87)
,(88, '11-03-2020', '11-05-2020', 'Skimmed, chemicals added', 3, 88)
,(89, '11-05-2020', '11-08-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 89)
,(90, '11-07-2020', '11-08-2020', 'Maintanence of pool.', 3, 90)
,(91, '11-09-2020', '11-10-2020', 'Maintanence performed. Cleaned pool', 3, 91)
,(92, '11-11-2020', '11-12-2020', 'Pool Installation and consultaion.', 3, 92)
,(93, '11-13-2020', '11-15-2020', 'Water testing and leak detection performed', 3, 93)
,(94, '11-15-2020', '11-18-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 94)
,(95, '11-17-2020', '11-19-2020', 'Water testing, pool skimmed, chemicals added', 3, 95)
,(96, '11-20-2020', '11-21-2020', 'Vacuumed, chemicals added, leak detection', 3, 96)
,(97, '11-21-2020', '11-22-2020', 'Water testing', 3, 97)
,(98, '11-22-2020', '11-24-2020', 'Skimmed, chemicals added', 3, 98)
,(99, '11-23-2020', '11-25-2020', 'Maintenence of pool. Water testing and adding chemicals.', 3, 99)
,(100, '11-25-2020', '11-26-2020', 'Maintanence of pool.', 3, 100)
,(101, '12-01-2020', '12-03-2020', 'Maintanence performed. Cleaned pool', 3, 101)
,(102, '12-02-2020', '12-10-2020', 'Pool Installation and consultaion.', 3, 102)
,(103, '12-04-2020', '12-07-2020', 'Water testing and leak detection performed', 3, 103)
,(104, '12-09-2020', '12-10-2020', 'Linear installation, water testing, chemicals add, filter backwashed', 3, 104)
,(105, '12-11-2020', '12-13-2020', 'Water testing, pool skimmed, chemicals added', 2, 105)
,(106, '12-13-2020', '12-15-2020', 'Vacuumed, chemicals added, leak detection', 2, 106)
,(107, '12-15-2020', '12-16-2020', 'Water testing', 1, 107)
,(108, '12-16-2020', '12-17-2020', 'Skimmed, chemicals added', 1, 108)

INSERT INTO TInvoices VALUES
-- intJobRecordID, DateDue, Jobcost, AmountPaid
(1, 1, '6-30-2020', 215, 215)
,(2, 2, '6-30-2020', 1250, 1250)
,(3, 3, '6-30-2020', 345, 345)
,(4, 4, '6-30-2020', 2060, 2060)
,(5, 5, '6-30-2020', 125, 125)
,(6, 6, '6-30-2020', 720, 720)
,(7, 7, '6-30-2020', 85, 85)
,(8, 8, '6-30-2020', 45, 45)
,(9, 9, '6-30-2020', 345, 345)
,(10, 10, '6-30-2020', 385, 385)
,(11, 11, '6-30-2020', 215, 215)
,(12, 12, '6-30-2020', 1250, 1250)
,(13, 13, '6-30-2020', 345, 345)
,(14, 14, '6-30-2020', 2060, 2060)
,(15, 15, '6-30-2020', 125, 125)
,(16, 16, '7-30-2020', 720, 720)
,(17, 17, '7-30-2020', 85, 85)
,(18, 18, '7-30-2020', 45, 45)
,(19, 19, '7-30-2020', 345, 345)
,(20, 20, '7-30-2020', 385, 385)
,(21, 21, '7-30-2020', 215, 215)
,(22, 22, '7-30-2020', 1250, 1250)
,(23, 23, '7-30-2020', 345, 345)
,(24, 24, '7-30-2020', 2060, 2060)
,(25, 25, '7-30-2020', 125, 125)
,(26, 26, '7-30-2020', 720, 720)
,(27, 27, '7-30-2020', 85, 85)
,(28, 28, '7-30-2020', 45, 45)
,(29, 29, '7-30-2020', 345, 345)
,(30, 30, '7-30-2020', 385, 385)
,(31, 31, '7-30-2020', 215, 215)
,(32, 32, '7-30-2020', 1250, 1250)
,(33, 33, '7-30-2020', 345, 345)
,(34, 34, '7-30-2020', 2060, 2060)
,(35, 35, '7-30-2020', 125, 125)
,(36, 36, '8-30-2020', 720, 720)
,(37, 37, '8-30-2020', 85, 85)
,(38, 38, '8-30-2020', 45, 45)
,(39, 39, '8-30-2020', 345, 345)
,(40, 40, '8-30-2020', 385, 385)
,(41, 41, '8-30-2020', 215, 215)
,(42, 42, '8-30-2020', 1250, 1250)
,(43, 43, '8-30-2020', 345, 345)
,(44, 44, '8-30-2020', 2060, 2060)
,(45, 45, '8-30-2020', 125, 125)
,(46, 46, '8-30-2020', 720, 720)
,(47, 47, '8-30-2020', 85, 85)
,(48, 48, '8-30-2020', 45, 45)
,(49, 49, '8-30-2020', 345, 345)
,(50, 50, '8-30-2020', 385, 385)
,(51, 51, '8-30-2020', 215, 215)
,(52, 52, '8-30-2020', 1250, 1250)
,(53, 53, '8-30-2020', 345, 345)
,(54, 54, '8-30-2020', 2060, 2060)
,(55, 55, '8-30-2020', 125, 125)
,(56, 56, '9-30-2020', 720, 720)
,(57, 57, '9-30-2020', 85, 85)
,(58, 58, '9-30-2020', 45, 45)
,(59, 59, '9-30-2020', 345, 345)
,(60, 60, '9-30-2020', 385, 385)
,(61, 61, '9-30-2020', 215, 215)
,(62, 62, '9-30-2020', 1250, 1250)
,(63, 63, '9-30-2020', 345, 345)
,(64, 64, '9-30-2020', 2060, 2060)
,(65, 65, '9-30-2020', 125, 125)
,(66, 66, '9-30-2020', 720, 720)
,(67, 67, '9-30-2020', 85, 85)
,(68, 68, '9-30-2020', 45, 45)
,(69, 69, '9-30-2020', 345, 345)
,(70, 70, '9-30-2020', 385, 385)
,(71, 71, '10-30-2020', 215, 215)
,(72, 72, '10-30-2020', 1250, 1250)
,(73, 73, '10-30-2020', 345, 345)
,(74, 74, '10-30-2020', 2060, 2060)
,(75, 75, '10-30-2020', 125, 125)
,(76, 76, '10-30-2020', 720, 720)
,(77, 77, '10-30-2020', 85, 85)
,(78, 78, '10-30-2020', 45, 45)
,(79, 79, '10-30-2020', 345, 345)
,(80, 80, '10-30-2020', 385, 385)
,(81, 81, '10-30-2020', 215, 215)
,(82, 82, '10-30-2020', 1250, 1250)
,(83, 83, '10-30-2020', 345, 345)
,(84, 84, '10-30-2020', 2060, 2060)
,(85, 85, '10-30-2020', 125, 125)
,(86, 86, '11-30-2020', 720, 720)
,(87, 87, '11-30-2020', 85, 85)
,(88, 88, '11-30-2020', 45, 45)
,(89, 89, '11-30-2020', 345, 345)
,(90, 90, '11-30-2020', 385, 385)
,(91, 91, '11-30-2020', 215, 215)
,(92, 92, '11-30-2020', 1250, 1250)
,(93, 93, '11-30-2020', 345, 345)
,(94, 94, '11-30-2020', 2060, 2060)
,(95, 95, '11-30-2020', 125, 125)
,(96, 96, '11-30-2020', 720, 720)
,(97, 97, '11-30-2020', 85, 85)
,(98, 98, '11-30-2020', 45, 45)
,(99, 99, '11-30-2020', 345, 345)
,(100, 100, '11-30-2020', 385, 385)
,(101, 101, '12-30-2020', 215, 215)
,(102, 102, '12-30-2020', 1250, 1250)
,(103, 103, '12-30-2020', 345, 245)
,(104, 104, '12-30-2020', 2060, 1030)

INSERT INTO TJobServices VALUES
--intServiceID, intJobRecordID, decServiceCost
(1, 4, 1, 85)
,(2, 5, 1, 35)
,(3, 6, 1, 50)
,(4, 7, 1, 45)
,(5, 1, 2, 1200)
,(6, 6, 2, 50)
,(7, 2, 3, 45)
,(8, 3, 3, 300)
,(9, 1, 4, 1920)
,(10, 2, 4, 45)
,(11, 6, 4, 50)
,(12, 7, 4, 45)
,(13, 2, 5, 45)
,(14, 5, 5, 35)
,(15, 6, 5, 45)
,(16, 3, 6, 500)
,(17, 4, 6, 170)
,(18, 6, 6, 50)
,(19, 5, 7, 35)
,(20, 6, 7, 50)
,(21, 2, 8, 45)
,(22, 2, 9, 45)
,(23, 4, 9, 170)
,(24, 5, 9, 35)
,(25, 6, 9, 50)
,(26, 7, 9, 45)
,(27, 4, 10, 255)
,(28, 5, 10, 35)
,(29, 6, 10, 50)
,(30, 7, 10, 45)
,(31, 4, 11, 85)
,(32, 5, 11, 35)
,(33, 6, 11, 50)
,(34, 7, 11, 45)
,(35, 1, 12, 1200)
,(36, 6, 12, 50)
,(37, 2, 13, 45)
,(38, 3, 13, 300)
,(39, 1, 14, 1920)
,(40, 2, 14, 45)
,(41, 6, 14, 50)
,(42, 7, 14, 45)
,(43, 2, 15, 45)
,(44, 5, 15, 35)
,(45, 6, 15, 45)
,(46, 3, 16, 500)
,(47, 4, 16, 170)
,(48, 6, 16, 50)
,(49, 5, 17, 35)
,(50, 6, 17, 50)
,(51, 2, 18, 45)
,(52, 2, 19, 45)
,(53, 4, 19, 170)
,(54, 5, 19, 35)
,(55, 6, 19, 50)
,(56, 7, 19, 45)
,(57, 4, 20, 255)
,(58, 5, 20, 35)
,(59, 6, 20, 50)
,(60, 7, 20, 45)
,(61, 4, 21, 85)
,(62, 5, 21, 35)
,(63, 6, 21, 50)
,(64, 7, 21, 45)
,(65, 1, 22, 1200)
,(66, 6, 22, 50)
,(67, 2, 23, 45)
,(68, 3, 23, 300)
,(69, 1, 24, 1920)
,(70, 2, 24, 45)
,(71, 6, 24, 50)
,(72, 7, 24, 45)
,(73, 2, 25, 45)
,(74, 5, 25, 35)
,(75, 6, 25, 45)
,(76, 3, 26, 500)
,(77, 4, 26, 170)
,(78, 6, 26, 50)
,(79, 5, 27, 35)
,(80, 6, 27, 50)
,(81, 2, 28, 45)
,(82, 2, 29, 45)
,(83, 4, 29, 170)
,(84, 5, 29, 35)
,(85, 6, 29, 50)
,(86, 7, 29, 45)
,(87, 4, 30, 255)
,(88, 5, 30, 35)
,(89, 6, 30, 50)
,(90, 7, 30, 45)
,(91, 4, 31, 85)
,(92, 5, 31, 35)
,(93, 6, 31, 50)
,(94, 7, 31, 45)
,(95, 1, 32, 1200)
,(96, 6, 32, 50)
,(97, 2, 33, 45)
,(98, 3, 33, 300)
,(99, 1, 34, 1920)
,(100, 2, 34, 45)
,(101, 6, 34, 50)
,(102, 7, 34, 45)
,(103, 2, 35, 45)
,(104, 5, 35, 35)
,(105, 6, 35, 45)
,(106, 3, 36, 500)
,(107, 4, 36, 170)
,(108, 6, 36, 50)
,(109, 5, 37, 35)
,(110, 6, 37, 50)
,(111, 2, 38, 45)
,(112, 2, 39, 45)
,(113, 4, 39, 170)
,(114, 5, 39, 35)
,(115, 6, 39, 50)
,(116, 7, 39, 45)
,(117, 4, 40, 255)
,(118, 5, 40, 35)
,(119, 6, 40, 50)
,(120, 7, 40, 45)
,(121, 4, 41, 85)
,(122, 5, 41, 35)
,(123, 6, 41, 50)
,(124, 7, 41, 45)
,(125, 1, 42, 1200)
,(126, 6, 42, 50)
,(127, 2, 43, 45)
,(128, 3, 43, 300)
,(129, 1, 44, 1920)
,(130, 2, 44, 45)
,(131, 6, 44, 50)
,(132, 7, 44, 45)
,(133, 2, 45, 45)
,(134, 5, 45, 35)
,(135, 6, 45, 45)
,(136, 3, 46, 500)
,(137, 4, 46, 170)
,(138, 6, 46, 50)
,(139, 5, 47, 35)
,(140, 6, 47, 50)
,(141, 2, 48, 45)
,(142, 2, 49, 45)
,(143, 4, 49, 170)
,(144, 5, 49, 35)
,(145, 6, 49, 50)
,(146, 7, 49, 45)
,(147, 4, 50, 255)
,(148, 5, 50, 35)
,(149, 6, 50, 50)
,(150, 7, 50, 45)
,(151, 4, 51, 85)
,(152, 5, 51, 35)
,(153, 6, 51, 50)
,(154, 7, 51, 45)
,(155, 1, 52, 1200)
,(156, 6, 52, 50)
,(157, 2, 53, 45)
,(158, 3, 53, 300)
,(159, 1, 54, 1920)
,(160, 2, 54, 45)
,(161, 6, 54, 50)
,(162, 7, 54, 45)
,(163, 2, 55, 45)
,(164, 5, 55, 35)
,(165, 6, 55, 45)
,(166, 3, 56, 500)
,(167, 4, 56, 170)
,(168, 6, 56, 50)
,(169, 5, 57, 35)
,(170, 6, 57, 50)
,(171, 2, 58, 45)
,(172, 2, 59, 45)
,(173, 4, 59, 170)
,(174, 5, 59, 35)
,(175, 6, 59, 50)
,(176, 7, 59, 45)
,(177, 4, 60, 255)
,(178, 5, 60, 35)
,(179, 6, 60, 50)
,(180, 7, 60, 45)
,(181, 4, 61, 85)
,(182, 5, 61, 35)
,(183, 6, 61, 50)
,(184, 7, 61, 45)
,(185, 1, 62, 1200)
,(186, 6, 62, 50)
,(187, 2, 63, 45)
,(188, 3, 63, 300)
,(189, 1, 64, 1920)
,(190, 2, 64, 45)
,(191, 6, 64, 50)
,(192, 7, 64, 45)
,(193, 2, 65, 45)
,(194, 5, 65, 35)
,(195, 6, 65, 45)
,(196, 3, 66, 500)
,(197, 4, 66, 170)
,(198, 6, 66, 50)
,(199, 5, 67, 35)
,(200, 6, 67, 50)
,(201, 2, 68, 45)
,(202, 2, 69, 45)
,(203, 4, 69, 170)
,(204, 5, 69, 35)
,(205, 6, 69, 50)
,(206, 7, 69, 45)
,(207, 4, 70, 255)
,(208, 5, 70, 35)
,(209, 6, 70, 50)
,(210, 7, 70, 45)
,(211, 4, 71, 85)
,(212, 5, 71, 35)
,(213, 6, 71, 50)
,(214, 7, 71, 45)
,(215, 1, 72, 1200)
,(216, 6, 72, 50)
,(217, 2, 73, 45)
,(218, 3, 73, 300)
,(219, 1, 74, 1920)
,(220, 2, 74, 45)
,(221, 6, 74, 50)
,(222, 7, 74, 45)
,(223, 2, 75, 45)
,(224, 5, 75, 35)
,(225, 6, 75, 45)
,(226, 3, 76, 500)
,(227, 4, 76, 170)
,(228, 6, 76, 50)
,(229, 5, 77, 35)
,(230, 6, 77, 50)
,(231, 2, 78, 45)
,(232, 2, 79, 45)
,(233, 4, 79, 170)
,(234, 5, 79, 35)
,(235, 6, 79, 50)
,(236, 7, 79, 45)
,(237, 4, 80, 255)
,(238, 5, 80, 35)
,(239, 6, 80, 50)
,(240, 7, 80, 45)
,(241, 4, 81, 85)
,(242, 5, 81, 35)
,(243, 6, 81, 50)
,(244, 7, 81, 45)
,(245, 1, 82, 1200)
,(246, 6, 82, 50)
,(247, 2, 83, 45)
,(248, 3, 83, 300)
,(249, 1, 84, 1920)
,(250, 2, 84, 45)
,(251, 6, 84, 50)
,(252, 7, 84, 45)
,(253, 2, 85, 45)
,(254, 5, 85, 35)
,(255, 6, 85, 45)
,(256, 3, 86, 500)
,(257, 4, 86, 170)
,(258, 6, 86, 50)
,(259, 5, 87, 35)
,(260, 6, 87, 50)
,(261, 2, 88, 45)
,(262, 2, 89, 45)
,(263, 4, 89, 170)
,(264, 5, 89, 35)
,(265, 6, 89, 50)
,(266, 7, 89, 45)
,(267, 4, 90, 255)
,(268, 5, 90, 35)
,(269, 6, 90, 50)
,(270, 7, 90, 45)
,(271, 4, 91, 85)
,(272, 5, 91, 35)
,(273, 6, 91, 50)
,(274, 7, 91, 45)
,(275, 1, 92, 1200)
,(276, 6, 92, 50)
,(277, 2, 93, 45)
,(278, 3, 93, 300)
,(279, 1, 94, 1920)
,(280, 2, 94, 45)
,(281, 6, 94, 50)
,(282, 7, 94, 45)
,(283, 2, 95, 45)
,(284, 5, 95, 35)
,(285, 6, 95, 45)
,(286, 3, 96, 500)
,(287, 4, 96, 170)
,(288, 6, 96, 50)
,(289, 5, 97, 35)
,(290, 6, 97, 50)
,(291, 2, 98, 45)
,(292, 2, 99, 45)
,(293, 4, 99, 170)
,(294, 5, 99, 35)
,(295, 6, 99, 50)
,(296, 7, 99, 45)
,(297, 4, 100, 255)
,(298, 5, 100, 35)
,(299, 6, 100, 50)
,(300, 7, 100, 45)
,(301, 4, 101, 85)
,(302, 5, 101, 35)
,(303, 6, 101, 50)
,(304, 7, 101, 45)
,(305, 1, 102, 1200)
,(306, 6, 102, 50)
,(307, 2, 103, 45)
,(308, 3, 103, 300)
,(309, 1, 104, 1920)
,(310, 2, 104, 45)
,(311, 6, 104, 50)
,(312, 7, 104, 45)
,(313, 2, 105, 45)
,(314, 5, 105, 35)
,(315, 6, 105, 45)
,(316, 3, 106, 500)
,(317, 4, 106, 170)
,(318, 6, 106, 50)
,(319, 5, 107, 35)
,(320, 6, 107, 50)
,(321, 2, 108, 45)

INSERT INTO TJobEmployees VALUES
--intJobRecordID, intEmplyeeID
(1, 1, 1)
,(2, 2, 2)
,(3, 2, 3)
,(4, 2, 4)
,(5, 3, 5)
,(6, 4, 6)
,(7, 4, 7)
,(8, 4, 8)
,(9, 5, 9)
,(10, 6, 10)
,(11, 7, 11)
,(12, 8, 12)
,(13, 9, 13)
,(14, 9, 14)
,(15, 10, 15)
,(16, 11, 1)
,(17, 12, 2)
,(18, 12, 3)
,(19, 12, 4)
,(20, 13, 5)
,(21, 14, 6)
,(22, 14, 7)
,(23, 14, 8)
,(24, 15, 9)
,(25, 16, 10)
,(26, 17, 11)
,(27, 18, 12)
,(28, 19, 13)
,(29, 19, 14)
,(30, 20, 15)
,(31, 21, 1)
,(32, 22, 2)
,(33, 22, 3)
,(34, 22, 4)
,(35, 23, 5)
,(36, 24, 6)
,(37, 24, 7)
,(38, 24, 8)
,(39, 25, 9)
,(40, 26, 10)
,(41, 27, 11)
,(42, 28, 12)
,(43, 29, 13)
,(44, 29, 14)
,(45, 30, 15)
,(46, 31, 1)
,(47, 32, 2)
,(48, 32, 3)
,(49, 32, 4)
,(50, 33, 5)
,(51, 34, 6)
,(52, 34, 7)
,(53, 34, 8)
,(54, 35, 9)
,(55, 36, 10)
,(56, 37, 11)
,(57, 38, 12)
,(58, 39, 13)
,(59, 39, 14)
,(60, 40, 15)
,(61, 41, 1)
,(62, 42, 2)
,(63, 42, 3)
,(64, 42, 4)
,(65, 43, 5)
,(66, 44, 6)
,(67, 44, 7)
,(68, 44, 8)
,(69, 45, 9)
,(70, 46, 10)
,(71, 47, 11)
,(72, 48, 12)
,(73, 49, 13)
,(74, 49, 14)
,(75, 50, 15)
,(76, 51, 1)
,(77, 52, 2)
,(78, 52, 3)
,(79, 52, 4)
,(80, 53, 5)
,(81, 54, 6)
,(82, 54, 7)
,(83, 54, 8)
,(84, 55, 9)
,(85, 56, 10)
,(86, 57, 11)
,(87, 58, 12)
,(88, 59, 13)
,(89, 59, 14)
,(90, 60, 15)
,(91, 61, 1)
,(92, 62, 2)
,(93, 62, 3)
,(94, 62, 4)
,(95, 63, 5)
,(96, 64, 6)
,(97, 64, 7)
,(98, 64, 8)
,(99, 65, 9)
,(100, 66, 10)
,(101, 67, 11)
,(102, 68, 12)
,(103, 69, 13)
,(104, 69, 14)
,(105, 70, 15)
,(106, 71, 1)
,(107, 72, 2)
,(108, 72, 3)
,(109, 72, 4)
,(110, 73, 5)
,(111, 74, 6)
,(112, 74, 7)
,(113, 74, 8)
,(114, 75, 9)
,(115, 76, 10)
,(116, 77, 11)
,(117, 78, 12)
,(118, 79, 13)
,(119, 79, 14)
,(120, 80, 15)
,(121, 81, 1)
,(122, 82, 2)
,(123, 82, 3)
,(124, 82, 4)
,(125, 83, 5)
,(126, 84, 6)
,(127, 84, 7)
,(128, 84, 8)
,(129, 85, 9)
,(130, 86, 10)
,(131, 87, 11)
,(132, 88, 12)
,(133, 89, 13)
,(134, 89, 14)
,(135, 90, 15)
,(136, 91, 1)
,(137, 92, 2)
,(138, 92, 3)
,(139, 92, 4)
,(140, 93, 5)
,(141, 94, 6)
,(142, 94, 7)
,(143, 94, 8)
,(144, 95, 9)
,(145, 96, 10)
,(146, 97, 11)
,(147, 98, 12)
,(148, 99, 13)
,(149, 99, 14)
,(150, 100, 15)
,(151, 101, 1)
,(152, 102, 2)
,(153, 102, 3)
,(154, 102, 4)
,(155, 103, 5)
,(156, 104, 6)
,(157, 104, 7)
,(158, 104, 8)
,(159, 105, 9)
,(160, 106, 10)

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

--SELECT * FROM vCustomers

GO

CREATE VIEW vBankAccount
AS
SELECT
	 BA.intBankAccountID
	,BA.intCustomerID
	,BA.strRoutingNumber
	,BA.strAccountNumber
	,BAT.strAccountTypeDesc
	,BA.strAccountName
FROM
	 TBankAccounts AS BA
	,TBankAccountTypes AS BAT
WHERE
	BA.intBankAccountTypeID = BAT.intBankAccountTypeID
GO


GO

CREATE VIEW vVendors
AS
SELECT
	 TV.intVendorID
	,TV.strVendorName
	,TV.strContactName
	,TV.strAddress
	,TV.strCity
	,TS.strState
	,TV.strZip
	,TV.strPhoneNumber
	,TV.strEmail
FROM
	 TVendors AS TV
	,TStates AS TS
WHERE
	TV.intStateID= TS.intStateID
GO



GO

CREATE VIEW vParts
AS
SELECT
	TP.intPartID
	,TP.intVendorID
	,TP.strSerialNumber
	,TP.strPartDesc
	,TP.intQuantity	
	,TP.intQuantityBackordered
	,TP.decUnitPurchaseCost
	,TP.decUnitSaleCost
	,TV.strVendorName
	,TV.strContactName
	,TV.strAddress
	,TV.strCity
	,TS.strState
	,TV.strZip
	,TV.strEmail
	,TV.strPhoneNumber
	,TP.strPartName
FROM
	TParts AS TP
	,TVendors AS TV
	,TStates as TS
WHERE
	TP.intVendorID = TV.intVendorID
	and TV.intStateID = TS.intStateID
GO


GO

CREATE VIEW vPartOrders
AS
SELECT
	TPO.intPartOrderedID
	,TP.strSerialNumber
	,TP.strPartDesc
	,TPO.intQuantity	
	,TPO.decUnitPurchaseCost
	,TV.strVendorName
	,TV.strContactName
	,TV.strAddress
	,TV.strCity
	,TS.strState
	,TV.strZip
	,TV.strEmail
	,TV.strPhoneNumber
	,TPO.dtDateOrdered
	,TPO.dtDateArrived
	,TPO.blnArrived
FROM
	TParts AS TP
	,TVendors AS TV
	,TStates AS TS
	,TPartsOrders AS TPO
WHERE
	TP.intVendorID = TV.intVendorID
	and TV.intStateID = TS.intStateID
	and TP.intPartID = TPO.intPartID
GO

--SELECT * FROM vParts

GO

CREATE VIEW vMonthAndYear
AS
SELECT
	 TF.intFinanceID
	,TM.strMonth
	,TY.strYear
FROM
	TFinances AS TF
	,TMonths AS TM
	,TYears AS TY
WHERE
	TF.intMonthID = TM.intMonthID
AND TF.intYearID = TY.intYearID
GO

--SELECT * FROM vMonthAndYear

GO

CREATE VIEW vMonthlyFinances
AS
SELECT
	distinct TF.intFinanceID
	,TF.decPayrollCost
	,TF.decInsuranceCost
	,TF.decVehicleCost
	,TF.decFuelCost
	,TF.decShopRental
	,TF.decUtilitiesCost
	,TF.decOtherCost
	,TF.decPayrollCost + TF.decInsuranceCost + TF.decVehicleCost + TF.decFuelCost + TF.decShopRental + TF.decUtilitiesCost + TF.decOtherCost AS TotalCost
	,TM.intMonthID
	,TY.strYear
	--,str((decRevenue - (decPayrollCost + decInventoryCost + decInsuranceCost + decProjectCost + decVehicleCost + decFuelCost + decShopRental + decUtilitiesCost + decOtherCost)), 7, 2) AS GrossProfit
	--,str(((decRevenue - (decPayrollCost + decInventoryCost + decInsuranceCost + decProjectCost + decVehicleCost + decFuelCost + decShopRental + decUtilitiesCost + decOtherCost)) / decRevenue) * 100, 7, 2) + '%' AS ProfitMargin
	
FROM
	TFinances AS TF
	,TMonths AS TM
	,TYears AS TY
WHERE
	TF.intMonthID = TM.intMonthID
AND TF.intYearID = TY.intYearID
GO


--SELECT * FROM vMonthlyFinances

GO

CREATE VIEW vYTDFinances
AS
SELECT
	TF.intFinanceID AS intFinanceID
	,SUM(TFMonth.decPayrollCost) AS PayrollYTD
	,SUM(TFMonth.decInsuranceCost) AS InsuranceYTD
	,SUM(TFMonth.decVehicleCost) AS VehicleYTD
	,SUM(TFMonth.decFuelCost) AS FuelYTD
	,SUM(TFMonth.decShopRental) AS ShopYTD
	,SUM(TFMonth.decUtilitiesCost) AS UtilityYTD
	,SUM(TFMonth.decOtherCost) AS OtherYTD
	,SUM(TFMonth.decPayrollCost + TFMonth.decInsuranceCost + TFMonth.decVehicleCost + TFMonth.decFuelCost + TFMonth.decShopRental + TFMonth.decUtilitiesCost +TFMonth.decOtherCost) AS TotalCostYTD

FROM
	TFinances AS TF
	join TYears AS TY ON TY.intYearID = TF.intYearID
	inner join TFinances AS TFMonth ON TF.intMonthID >= TFMonth.intMonthID
	and TY.intYearID = TFMonth.intYearID
	join TMonths AS TM ON TM.intMonthID = TF.intMonthID
	
GROUP BY
	TF.intFinanceID
GO

GO

CREATE VIEW vJobRecordCustomers
AS
SELECT
	 distinct TC.intCustomerID
	,TC.strLastName + ', '+ TC.strFirstName AS FullName
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
WHERE
	TC.intCustomerID = TJ.intCustomerID
GO

GO

CREATE VIEW vJobRecordsSearch
AS
SELECT
	 distinct TC.intCustomerID
	,TC.strFirstName 
	,TC.strLastName
	,TC.strLastName + ', '+ TC.strFirstName AS FullName
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
WHERE
	TC.intCustomerID = TJ.intCustomerID
GO

GO

CREATE VIEW vJobRecordNumber
AS
SELECT
	TC.intCustomerID
	,TJ.intJobRecordID
	,TJ.JobNumber AS strJobNumber
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
WHERE
	TC.intCustomerID = TJ.intCustomerID
GO

GO

CREATE VIEW vJobRecords
AS
SELECT
	 TJ.intJobRecordID
	,TJ.JobNumber
	,TJ.dtStartDate
	,TJ.dtEndDate
	,TJ.strJobDesc
	,TJ.intStatusID
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
WHERE
	TC.intCustomerID = TJ.intCustomerID
GO


GO

CREATE VIEW vCustomersWithInvoices
AS
SELECT 
		distinct TJR.intCustomerID
		,(tc.strLastName + ', ' + tc.strFirstName) AS FullName
FROM
	 TCustomers AS TC	
	,TInvoices AS TI
	,TJobRecords AS TJR
WHERE TJR.intCustomerID = TC.intCustomerID
	AND TJR.intJobRecordID = TI.intJobRecordID
GO

--select * from vCustomersWithInvoices


GO
CREATE VIEW vCustomerInvoices
AS
SELECT
	 TI.intInvoiceID
	,TI.CIN
	,TC.intCustomerID
FROM
	TInvoices As TI
	,TCustomers AS TC
	,TJobRecords AS TJ
WHERE TC.intCustomerID = TJ.intCustomerID AND
	  TI.intJobRecordID = TJ.intJobRecordID
GO	


GO
CREATE VIEW vPrintableInvoice
AS
SELECT
	 TI.intInvoiceID
	,TI.CIN
	,TI.dtDateDue
	,TC.intCustomerID
	,TJ.intJobRecordID
	,TI.decJobCost
FROM
	TInvoices As TI
	,TCustomers AS TC
	,TJobRecords AS TJ
WHERE TC.intCustomerID = TJ.intCustomerID AND
	  TI.intJobRecordID = TJ.intJobRecordID
GO	


GO
CREATE VIEW vJobRecordStatus
AS
SELECT
	 TJ.intJobRecordID
	,TJ.intCustomerID
	,TJ.JobNumber
	,TJ.dtStartDate
	,TJ.dtEndDate
	,TJ.strJobDesc
	,TS.strStatus
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
	,TStatuses AS TS
WHERE
	TC.intCustomerID = TJ.intCustomerID
	AND TJ.intStatusID = TS.intStatusID
GO


GO
CREATE VIEW vJobAndCustomerInfo
AS
SELECT
	 TJ.JobNumber
	,(TC.strFirstName + ' ' + TC.strLastName) AS Name
	,TJ.dtStartDate
	,TJ.dtEndDate
	,TJ.strJobDesc
	,TS.strStatus
	,TJ.intJobRecordID
FROM
	 TCustomers AS TC
	,TJobRecords AS TJ
	,TStatuses AS TS
WHERE
	TC.intCustomerID = TJ.intCustomerID
	AND TJ.intStatusID = TS.intStatusID
GO


GO
CREATE VIEW vJobsWithoutInvoices
AS
SELECT
	 Distinct TJ.intJobRecordID
	,TJ.JobNumber
	,TJ.intCustomerID
	,TJ.intStatusID
FROM
	 TJobRecords AS TJ
WHERE
	NOT EXISTS(SELECT intJobRecordID FROM TInvoices WHERE TJ.intJobRecordID = TInvoices.intJobRecordID)
GO


GO
CREATE VIEW vEmployeeNames
AS
SELECT
	(TE.strFirstName + ' ' + TE.strLastName) AS EmpName
	,TJE.intJobRecordID
FROM
	 TEmployees AS TE
	,TJobEmployees AS TJE
WHERE TE.intEmployeeID = TJE.intEmployeeID
GO


GO
CREATE VIEW vJobsAndNoInvoice
AS
SELECT
	 distinct TC.intCustomerID
	,TC.strLastName + ', '+ TC.strFirstName AS FullName
	,TJ.intJobRecordID
FROM
	TCustomers AS TC
	,TJobRecords AS TJ
WHERE
	TC.intCustomerID = TJ.intCustomerID AND
	TJ.intStatusID = 3 AND
	NOT EXISTS(SELECT intJobRecordID FROM TInvoices WHERE TJ.intJobRecordID = TInvoices.intJobRecordID)
GO

GO

CREATE VIEW vMonthlyRevenue
AS
SELECT
	SUM(TI.decJobCost) AS Total
	,SUM(TI.decAmountPaid) AS Paid
	,MONTH(TI.dtDateDue) AS MonthDate
	,YEAR(TI.dtDateDue) AS YearDate
FROM
	TInvoices AS TI

GROUP BY
	MONTH(TI.dtDateDue)
	,YEAR(TI.dtDateDue)
GO

GO

CREATE VIEW vPartsOrderedCost
AS
SELECT
	SUM(TPO.decUnitPurchaseCost) AS TotalCost
	,MONTH(TPO.dtDateArrived) AS MonthDate
	,YEAR(TPO.dtDateArrived) AS YearDate
FROM
	TPartsOrders AS TPO

GROUP BY
	MONTH(TPO.dtDateArrived)
	,YEAR(TPO.dtDateArrived)
GO

GO

CREATE VIEW vEmployeesOnJob
AS
SELECT
	TE.strLastName + ', ' + TE.strFirstName AS FullName
	,TJE.intJobRecordID
FROM
	 TEmployees AS TE
	,TJobEmployees AS TJE
WHERE
	TE.intEmployeeID = TJE.intEmployeeID
	
GO


--Select * from vMonthlyRevenue where YearDate = 2020 
--Select SUM(Total), SUM(Paid) from vMonthlyRevenue where YearDate = 2020 and MonthDate <= 8
--SELECT * FROM vYTDFinances


--SELECT
--	('$' + CONVERT(VARCHAR, SUM(TP.decUnitSaleCost * TJP.intPartQuantity))) AS Cost
--From
--	 TParts AS TP
--	,TJobParts AS TJP
--	,TJobRecords AS TJ
--WHERE TJP.intPartID = TP.intPartID
--AND TJP.intJobRecordID = TJ.intJobRecordID
--AND TJ.intJobRecordID = 109

--select * from vPrintableInvoice

--SELECT * FROM vJobsAndNoInvoice ORDER BY FullName ASC

--select * from vEmployeeNames where intjobrecordID = 72