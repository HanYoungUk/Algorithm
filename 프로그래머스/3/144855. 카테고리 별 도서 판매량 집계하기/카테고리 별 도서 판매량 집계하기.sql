-- 코드를 입력하세요
SELECT CATEGORY, sum(SALES) as TOTAL_SALES
from BOOK 
join BOOK_SALES using (BOOK_ID)
where SALES_DATE like '%2022-01%'
group by CATEGORY
order by 1