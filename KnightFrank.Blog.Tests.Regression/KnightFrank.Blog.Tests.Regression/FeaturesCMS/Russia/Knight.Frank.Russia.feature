Feature: Knight Frank Russia Website


Background: User has visited Knight Frank Russia Domain
	Given user has visited Knight Frank Russia domain

Scenario Outline: Russia Global Navigation is visible
	Then user should see <russiaGlobalNav> site Global Navigation

Examples: 
	| russiaGlobalNav |
	| Страна:         |
	| Language:       |
	| Контакты        |
	| Новости         |
	| Карьера         |


Scenario Outline: Russia Site Navigation is Visible 
	Then user should see <russiaSiteNav> site navigation

Examples: 
	| russiaSiteNav |
	| Недвижимость  |
	| Сотрудники    |
	| Услуги        |
	| Исследования  |
	| Blog          |

Scenario Outline: Russia Search box tabs are visible
	Then user should see <russiaSearchTabs> search box tabs

Examples: 
	| russiaSearchTabs      |
	| Недвижимость в России |
	| Жилая в мире          |
	| Коммерческая в мире   |
	| Люди/Офисы            |
	| Услуги                |
	| Исследования          |

Scenario: Russia Search tool placeholder text
	Then user should see the russia search box text
	| searchWaterMark                       |
	| Выберите регион или город, для поиска |