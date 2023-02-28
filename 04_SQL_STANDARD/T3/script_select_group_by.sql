select category.name, subTable.rating, subTable.total_films from film 
inner join film_category on film_category.film_id = film.film_id
inner join category on category.category_id = film_category.category_id
inner join 
(
select count(*) total_films, rating from film
group by rating having count(*) > 200
) subTable on film.rating = subTable.rating
group by category.name, subTable.rating, subTable.total_films
order by subTable.total_films desc