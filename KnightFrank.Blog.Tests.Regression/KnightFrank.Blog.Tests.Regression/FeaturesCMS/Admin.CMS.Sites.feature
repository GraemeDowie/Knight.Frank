Feature: Admin Sites are working and able to log in 



Scenario Outline: User has visited AdminCMS and login With valid credentials
	Given user has visited <adminCMS> adminCMS	
	When user login with valid credentials
	| userName                | Password |
	| digital@knightfrank.com | Pa55word |
	Then user should see log in details and CMS dashboard

Examples: 
	| adminCMS                                                 |
	| http://beta.admincms.knightfrank.co.uk/admin/login.aspx  |
	| http://beta.admincms.knightfrank.com/admin/login.aspx    |
	| http://beta.admincms.knightfrank.com.ro/admin/login.aspx |
	| http://beta.admincms.knightfrank.cz/admin/login.aspx     |
	| http://beta.admincms.knightfrank.it/admin/login.aspx     |
	| http://beta.admincms.knightfrank.ae/admin/login.aspx     |
	| http://beta.admincms.knightfrank.ie/admin/login.aspx     |
	| http://beta.admincms.knightfrank.ru/admin/login.aspx     |
	| http://beta.admincms.knightfrank.qa/admin/login.aspx     |
	| http://beta.admincms.knightfrank.fr/admin/login.aspx     |
	| http://beta.admincms.knightfrank.de/admin/login.aspx     |
	| http://beta.admincms.knightfrank.es/admin/login.aspx     |
	| http://beta.admincms.knightfrank.com.pl/admin/login.aspx |
	| http://beta.admincms.knightfrank.be/admin/login.aspx     |
	| http://beta.admincms.knightfrank.co.ke/admin/login.aspx  |
	| http://beta.admincms.knightfrank.mw/admin/login.aspx     |
	| http://beta.admincms.knightfrank.com.ng/admin/login.aspx |
	| http://beta.admincms.knightfrank.rw/admin/login.aspx     |
	| http://beta.admincms.knightfrank.co.za/admin/login.aspx  |
	| http://beta.admincms.knightfrank.co.tz/admin/login.aspx  |
	| http://beta.admincms.knightfrank.ug/admin/login.aspx     |
	| http://beta.admincms.knightfrank.co.zw/admin/login.aspx  |

	