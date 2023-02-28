
select 'Mayor cantidad' query_type, 
subTable2.total_films, actor.actor_id, actor.first_name, actor.last_name from
(
	select max(total_films) max_films
	from
	(
		SELECT count(*) total_films, actor_id 
		from film_actor 
		group by actor_id
	) subTable
) subTableMax
inner join 
(
	SELECT count(*) total_films, actor_id 
	from film_actor 
	group by actor_id
) subTable2 on subTableMax.max_films = subTable2.total_films
inner join actor on actor.actor_id = subTable2.actor_id

union


select 'Menor cantidad' query_type, 
subTable2.total_films, actor.actor_id, actor.first_name, actor.last_name from
(
	select min(total_films) max_films
	from
	(
		SELECT count(*) total_films, actor_id 
		from film_actor 
		group by actor_id
	) subTable
) subTableMax
inner join 
(
	SELECT count(*) total_films, actor_id 
	from film_actor 
	group by actor_id
) subTable2 on subTableMax.max_films = subTable2.total_films
inner join actor on actor.actor_id = subTable2.actor_id