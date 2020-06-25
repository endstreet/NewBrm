
--
-- DC_ACTIVITY
--
  CREATE TABLE "DC_ACTIVITY" 
   (	"ID" NUMBER(*,0) GENERATED ALWAYS AS IDENTITY
 MINVALUE 1 MAXVALUE 999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOORDER NOCYCLE NOT NULL ENABLE,
	"USERNAME" NVARCHAR2(50) NOT NULL ENABLE,
	"AREA" VARCHAR2(50) NOT NULL ENABLE,
	"ACTIVITY" NVARCHAR2(255) NOT NULL ENABLE,
	"RESULT" NVARCHAR2(255) NOT NULL ENABLE,
	"USERID" NUMBER(*,0),
	"ACTIVITY_DATE" DATE DEFAULT CURRENT_DATE NOT NULL ENABLE
   );