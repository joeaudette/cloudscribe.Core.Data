SET TERM ^ ;
CREATE PROCEDURE MP_ROLES_INSERT (
    SITEID Integer,
    ROLENAME Varchar(50),
    DISPLAYNAME Varchar(50),
    SITEGUID Char(36),
    ROLEGUID Char(36) )
RETURNS (
    ROLEID Integer )
AS
BEGIN EXIT; END^
SET TERM ; ^


SET TERM ^ ;
CREATE PROCEDURE MP_SITES_INSERT (
    SITEGUID Char(36),
    SITENAME Varchar(255),
    SKIN Varchar(100),
    ALLOWNEWREGISTRATION Smallint,
    USESECUREREGISTRATION Smallint,
    ISSERVERADMINSITE Smallint,
    USELDAPAUTH Smallint,
    AUTOCREATELDAPUSERONFIRSTLOGIN Smallint,
    LDAPSERVER Varchar(255),
    LDAPPORT Integer,
    LDAPDOMAIN Varchar(255),
    LDAPROOTDN Varchar(255),
    LDAPUSERDNKEY Varchar(10),
    REALLYDELETEUSERS Smallint,
    USEEMAILFORLOGIN Smallint,
    REQUIRESQUESTIONANDANSWER Smallint,
    MAXINVALIDPASSWORDATTEMPTS Integer,
    MINREQUIREDPASSWORDLENGTH Integer,
    DEFAULTEMAILFROMADDRESS Varchar(100),
    RECAPTCHAPRIVATEKEY Varchar(255),
    RECAPTCHAPUBLICKEY Varchar(255)
    )
RETURNS (
    SITEID Integer )
AS
BEGIN EXIT; END^
SET TERM ; ^

SET TERM ^ ;
CREATE PROCEDURE MP_USERROLES_INSERT (
    USERID Integer,
    ROLEID Integer,
    USERGUID Char(36),
    ROLEGUID Char(36) )
RETURNS (
    ID Integer )
AS
BEGIN EXIT; END^
SET TERM ; ^

SET TERM ^ ;
CREATE PROCEDURE MP_USERS_INSERT (
    SITEID Integer,
    NAME Varchar(100),
    LOGINNAME Varchar(50),
    EMAIL Varchar(100),
    LOWEREDEMAIL Varchar(100),
    "PASSWORD" Varchar(128),
    GENDER Char(10),
    TRUSTED Smallint,
    DISPLAYINMEMBERLIST Smallint,
    WEBSITEURL Varchar(100),
    COUNTRY Varchar(100),
    STATE Varchar(100),
    AVATARURL Varchar(255),
    SIGNATURE Varchar(255),
    DATECREATED Timestamp,
    USERGUID Char(36),
    SKIN Varchar(100),
    ISDELETED Smallint,
    FAILEDPASSWORDATTEMPTCOUNT Integer,
    ISLOCKEDOUT Smallint,
    "COMMENT" Blob sub_type 1,
    SITEGUID Char(36) )
RETURNS (
    USERID Integer )
AS
BEGIN EXIT; END^
SET TERM ; ^
