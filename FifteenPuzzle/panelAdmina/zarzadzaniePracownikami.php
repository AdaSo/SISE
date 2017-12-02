<!DOCTYPE html>
<html lang="pl">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Zarządzanie pracownikami</title>
	<link rel="stylesheet" href="adminStyle.css"/>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    </head>
    <body>
      <p><br/></p>
      <div class="container">
      <div id="logo">
        <h1> Zarządzanie pracownikami</h1>
     </div>
          <form action="addPracownikDialog.php">
              <button class="btn btn-primary" type="submit"> Insert Data</button>
          </form>
          <br></br>
          <table class = "table table-bordered table-striped">
              <thead>
                  <tr>
                      <th width="40">ID</th>
                      <th>Imię</th>
                      <th>Nazwisko</th>
                      <th>Płeć</th>
                      <th>Pesel</th>
                      <th>Data zatrudnienia</th>     
                      <th>specjalizacja</th>                               
                      <th width="180">Akcja</th>                   
                  </tr>               
              </thead>
              <tbody>
  <?php
      include_once "config.php";
  
      $url = $url_base."lekarze/get" ;       
      $ch = curl_init(); 
      curl_setopt($ch, CURLOPT_URL, $url); 
      curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
      curl_setopt($ch, CURLOPT_VERBOSE, 0);
      curl_setopt($ch, CURLOPT_HEADER, 1);
  
      $response = curl_exec($ch);
  
      // Then, after your curl_exec call:
      $header_size = curl_getinfo($ch, CURLINFO_HEADER_SIZE);
     // $header = substr($response, 0, $header_size);
      $body = substr($response, $header_size);
  
      $json = json_decode($body, true);
      $iterator =0;
  foreach($json as &$aaa){
      $help = $aaa;
      $id= $help['id'];
      $imie= $help['imie'];
      $nazwisko= $help['nazwisko'];
      $plec=$help['plec'];
      $pesel=$help['pesel']; 
      $stan= $help['dataZatrudnienia'];
      $specj= $help['specjalizacja'];
      
echo<<<END
      <tr>
          <th>$id</th>
          <th>$imie</th>
          <th>$nazwisko</th>
          <th>$plec</th>
          <th>$pesel</th>   
          <th>$stan</th>                      
          <th>
              <form > <!--action="editDialog.html">-->
                  <button class="btn btn-warning" type="submit">Edit</button> 
                  <button class="btn btn-danger">Delete</button>                            
              </form>                                  
          </th> 
      </tr>
END;
  }
  ?>    
              </tbody>
          </table>   
      </div>
    </body>
  </html>