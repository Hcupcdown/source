var mysql      = require('mysql');
var connection = mysql.createConnection({
  host     : 'localhost',
  user     : 'root',
  password : 'lzjbyjava',
  database : 'test'
});
 
connection.connect();
 
var sql='select * from customer'
connection.query(sql, function (error, results) {
  if (error) 
  {
    throw error;
  }
  console.log(results);
});