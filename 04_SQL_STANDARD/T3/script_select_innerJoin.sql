SELECT city_id, city, country, country.last_update FROM country
inner join city on country.country_id = city.country_id 
where country.country_id = 1