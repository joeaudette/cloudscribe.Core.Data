ALTER TABLE `mp_UserClaims` ADD COLUMN `SiteId` INTEGER NOT NULL default -1;

ALTER TABLE `mp_UserLogins` ADD COLUMN `SiteId` INTEGER NOT NULL default -1;

ALTER TABLE `mp_UserLogins` ADD COLUMN `ProviderDisplayName` varchar(100);

CREATE INDEX IX_mp_UserLoginsSite ON mp_UserLogins(`SiteId`);

CREATE INDEX IX_mp_UserClaimsSite ON mp_UserClaims(`SiteId`);



