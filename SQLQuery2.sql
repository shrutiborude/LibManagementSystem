DELETE FROM Books 
WHERE ID NOT IN (
    SELECT MIN(ID) FROM Books 
    GROUP BY Name, Author
);
