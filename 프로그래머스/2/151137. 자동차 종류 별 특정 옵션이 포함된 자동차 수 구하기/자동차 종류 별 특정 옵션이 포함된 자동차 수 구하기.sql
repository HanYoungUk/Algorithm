SELECT car_type ,count(car_type) as 'CARS'
from CAR_RENTAL_COMPANY_CAR
where options like '%통풍%' or options like '%열선%' or options like '%가죽%'
group by CAR_TYPE
order by car_type