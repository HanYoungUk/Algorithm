-- 코드를 입력하세요
SELECT Hour(DATETIME) as HOUR , count(ANIMAL_ID) as COUNT
FROM ANIMAL_OUTS
group by Hour(DATETIME)
HAVING HOUR >= 9 AND HOUR <= 19 
order by 1