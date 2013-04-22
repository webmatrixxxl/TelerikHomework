    <!DOCTYPE html>
    <html>
    <head>
            <title>Calculator</title>
    </head>
    <body>
            <?php
                    $value1 = $_GET['value1'];
                    $value2 = $_GET['value2'];
                    $sing = $_GET['sing'];
                    $corectSing = $sing == '+' || $sing == '-' || $sing == '*' || $sing == '/';
                    if(is_numeric($value1) && is_numeric($value2) && $corectSing)
                    {
                            echo($value1 . " " .  $sing . " " . $value2 . " = ");
                            switch($sing)
                            {
                                    case '+': echo($value1 + $value2); break;
                                    case '-': echo($value1 - $value2); break;
                                    case '*': echo($value1 * $value2); break;
                                    default: echo($value1 / $value2); break;
                            }
                    }
                    else
                    {
                            echo("Incorrect input <br /><a href='calculator.html'>Back to calculator</a>");
                    }
            ?>
    </body>
    </html>
