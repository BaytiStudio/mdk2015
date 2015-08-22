<div class="container">
  <h2 class="text-center">Lapor Harga Barang</h2>
  <form class="" action="../db/lapor.php" method="post">
    <div class="row">
    <div class="form-group">
      <div class="col-md-4">
      </div>
      <table class="col-md-4">
        <tr class="form-horizontal">
          <td>
            <h5>Provinsi</h5>
          </td>
          <td>
            <!-- <input type="text" name="" value="" placeholder="Jakarta" class="form-control"> -->
            <select name="prop" id="prop" onchange="ajaxkota(this.value)">
              <option value="">Pilih Provinsi</option>
              <?php 
              $queryProvinsi=mysql_query("SELECT * FROM inf_lokasi where lokasi_kabupatenkota=0 and lokasi_kecamatan=0 and lokasi_kelurahan=0");
              while ($dataProvinsi=mysql_fetch_array($queryProvinsi)){
                echo '<option value="'.$dataProvinsi['lokasi_propinsi'].'">'.$dataProvinsi['lokasi_nama'].'</option>';
              }
              ?>
            </select>
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Kota/Kabupaten</h5>
          </td>
          <td>
            <!-- <input type="text" name="" value="" placeholder="Jakarta Selatan" class="form-control"> -->
            <select name="kota" id="kota" onchange="ajaxkec(this.value)">
              <option value="">Pilih Kota</option>
            </select>
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Kecamatan</h5>
          </td>
          <td>
            <!-- <input type="text" name="" value="" placeholder="Cilandak" class="form-control"> -->
            <select name="kec" id="kec" onchange="ajaxkel(this.value)">
              <option value="">Pilih Kecamatan</option>
            </select>
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Kelurahan</h5>
          </td>
          <td>
            <!-- <input type="text" name="" value="" placeholder="apa aja" class="form-control"> -->
            <select name="kel" id="kel">
              <option value="">Pilih Kelurahan/Desa</option>
            </select>
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Pasar</h5>
          </td>
          <td>
            <input type="text" name="nama_pasar" value="" placeholder="apa aja" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Komoditas</h5>
          </td>
          <td>
            <input type="text" name="nama_komoditas" value="" placeholder="Beras" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Jenis</h5>
          </td>
          <td>
            <input type="text" name="jenis_komoditas" value="" placeholder="Raskin" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Harga</h5>
          </td>
          <td>
            <input type="text" name="harga" value="" placeholder="50000" class="form-control">
          </td>
        </tr>
        <tr>
          <td>
            &nbsp;
          </td>
        </tr>
        <tr>
          <td colspan="2" class="text-center">
            <button type="submit" name="" class="btn btn-primary">Submit</button>
          </td>
        </tr>
      </table>
    </div>
    </div>
  </form>
</div>
