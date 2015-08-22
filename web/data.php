<div class="container">


    <div class="row">


    <div class="col-md-7">
      <h1>Komoditas</h1><br>
      <h6>Nasional</h6>
    </div>
    <div class="col-md-3">
      <table>
        <tr>
          <h3>harga kemarin</h3>
        </tr>
        <tr>
          <h3>5000</h3>
        </tr>
        <tr>
          <h3>harga sekarang</h3>
        </tr>
        <tr>
          <h3>5500</h3>
        </tr>
      </table>

    </div>
    <div class="col-md-2">
      <i class="fa fa-arrow-up" style="margin-top:25%;color:red;"></i>
      <h5>naik</h5>
      <i class="fa fa-arrow-down" style="margin-top:25%;color:green;"></i>
      <h5>turun</h5>
    </div>
    </div>
    <hr>
    <div class="row">
      <div class="col-md-8">
        <h3>kolom berita</h3>
        <?php 
            $html = bacaHTML("http://ews.kemendag.go.id/");
            $div_open = explode('<div class="content-wrapper fl-left bggrey">', $html);
            $berita1 = str_replace("src=\"", "src=\"http://ews.kemendag.go.id/", $div_open[1]);
            echo "<div>".$berita1;
            $div_close = explode('</div>', $div_open[2]);
            $berita2 = str_replace("src=\"", "src=\"http://ews.kemendag.go.id/", $div_close[0]);
            echo "<div>".$berita2."</div>";
         ?>
      </div>
      <div class="col-md-4">
        <h3>kolom tweet</h3>
        <a class="twitter-timeline" href="https://twitter.com/search?q=Harga%20beras%20Harga%20Daging%20Harga%20Gula" data-widget-id="635107049907490816">Tweet tentang Harga beras Harga Daging Harga Gula</a>
<script>!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+"://platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");</script>
      </div>
    </div>

<!--
<br>
<button type="button" class="btn btn-info">This is a button</button>
-->
</div>
