<!DOCTYPE html>
<html lang="pl">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Zarządzanie pacjentami - dodawanie </title>

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
        <p></p>
        <div  id="addData" tabindex="-1" role="dialog" aria-labelledby="addLabel">
            <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                                   
                <h4 class="modal-title" id="addLabel">Dodanie pacjenta</h4>           
                <div>
                    <form> 
                        <div class="modal-body">                               
                            <div class="form-group">
                                <label for="nm">Imię</label>
                                <input type="text" class="form-control" id="nm" placeholder="Imię">
                            </div>
                            <div class="form-group">
                                <label for="nm">Nazwisko</label>
                                <input type="text" class="form-control" id="sur" placeholder="Nazwisko">
                            </div>
                            <div class="form-group">
                                <label for="nm">Płeć</label>
                                <input type="text" class="form-control" id="sur" placeholder="Płeć">
                            </div>
                            <div class="form-group">
                                <label for="ph">Pesel</label>
                                <input type="number" class="form-control" id="pesel" placeholder="Pesel">
                            </div>   
                            <div class="form-group">
                                <label for="ph">Stan</label>
                                <input type="number" class="form-control" id="data" placeholder="Data zatrudnienia">
                            </div> 
                     
                        </div>
                        <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <button type="submit" onclick="saveData()" class="btn btn-primary">Save changes</button>
                        </div>
                    </form>
                </div>
                </div>


            </div>
            </div>
        </div>
        <p></p>
        
    </div>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script>
        function saveData() {
            var name = $('#nm').val();
            var email = $('#em').val();
            var phone = $('#ph').val();
            var adress = $('#ad').val();

            $.ajax({
                type: "POST",
                url: "server.php?p=add",
                data: "nm" + name +" &em" + email  + "&hp" +phone + "&ad" + adress,
                success: function(msg) {
                        alert('Succes insert');
                }
            })
            
        }
    </script>
  </body>
</html>