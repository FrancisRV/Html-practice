<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Responsive Layout</title>
<style>

/********** Base styles **********/
* {
  box-sizing: border-box;
}
h1 {
  margin-bottom: 15px;
}

p {
  border: 1px solid black;
  background-color: #A52A2A;
  width: 90%;
  height: 150px;
  margin-right: auto;
  margin-left: auto;
  font-family: Helvetica;
  color: white;
}

/* Simple Responsive Framework. */
.row {
  width: 100%;
}

/********** Large devices only **********/
@media (min-width: 1200px) {
  .col-lg-1, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-10, .col-lg-11, .col-lg-12 {
    float: left;
    border: 1px solid green;
  }
  .col-lg-1 {
    width: 8.33%;
  }
  .col-lg-2 {
    width: 16.66%;
  }
  .col-lg-3 {
    width: 25%;
  }
  .col-lg-4 {
    width: 33.33%;
  }
  .col-lg-5 {
    width: 41.66%;
  }
  .col-lg-6 {
    width: 50%;
  }
  .col-lg-7 {
    width: 58.33%;
  }
  .col-lg-8 {
    width: 66.66%;
  }
  .col-lg-9 {
    width: 74.99%;
  }
  .col-lg-10 {
    width: 83.33%;
  }
  .col-lg-11 {
    width: 91.66%;
  }
  .col-lg-12 {
    width: 100%;
  }
}

/********** Medium devices only **********/
@media (min-width: 992px) and (max-width: 1199px) {
  .col-md-1, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-10, .col-md-11, .col-md-12 {
    float: left;
    border: 1px solid rgb(32, 65, 148);
  }
  .col-md-1 {
    width: 8.33%;
  }
  .col-md-2 {
    width: 16.66%;
  }
  .col-md-3 {
    width: 25%;
  }
  .col-md-4 {
    width: 33.33%;
  }
  .col-md-5 {
    width: 41.66%;
  }
  .col-md-6 {
    width: 50%;
  }
  .col-md-7 {
    width: 58.33%;
  }
  .col-md-8 {
    width: 66.66%;
  }
  .col-md-9 {
    width: 74.99%;
  }
  .col-md-10 {
    width: 83.33%;
  }
  .col-md-11 {
    width: 91.66%;
  }
  .col-md-12 {
    width: 100%;
  }
}

/********** Small devices only **********/
@media (max-width: 767px) {
  .col-xs-1, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9, .col-xs-10, .col-xs-11, .col-xs-12 {
    float: left;
    border: 1px solid rgb(126, 20, 20);
  }
  .col-xs-1 {
    width: 8.33%;
  }
  .col-xs-2 {
    width: 16.66%;
  }
  .col-xs-3 {
    width: 25%;
  }
  .col-xs-4 {
    width: 33.33%;
  }
  .col-xs-5 {
    width: 41.66%;
  }
  .col-xs-6 {
    width: 50%;
  }
  .col-xs-7 {
    width: 58.33%;
  }
  .col-xs-8 {
    width: 66.66%;
  }
  .col-xs-9 {
    width: 74.99%;
  }
  .col-xs-10 {
    width: 83.33%;
  }
  .col-xs-11 {
    width: 91.66%;
  }
  .col-xs-12 {
    width: 100%;
  }
}

</style>
</head>
<body>
<h1>Responsive Layout</h1>

<div class="row">
  <div class="col-lg-3 col-md-6"><p>Item 1</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 2</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 3</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 4</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 5</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 6</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 7</p></div>
  <div class="col-lg-3 col-md-6"><p>Item 8</p></div>
</div>

</body>
</html>