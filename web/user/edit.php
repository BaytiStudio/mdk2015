<?php 
  $id_user = $_SESSION['user_id'];
  $sql = "SELECT * FROM user WHERE id =$id_user";
  $result = mysql_query($sql)or die(mysql_error());
  $hasil = mysql_fetch_array($result);
 ?>
<div class="container">
  <h2 class="text-center">Edit User</h2>
  <form class="" action="../db/update.php" method="post">
    <div class="row">
    <div class="form-group">
      <div class="col-md-4">
      </div>
      <table class="col-md-4">
        <tr class="form-horizontal">
          <!-- <td>
            <h5>Foto</h5>
          </td>
          <td>
            <input type="text" name="" value="" placeholder="Jakarta" class="form-control">
          </td> -->
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Nama</h5>
          </td>
          <td>
            <!-- <h5>wawan mtd</h5> -->
            <input type="text" name="nama" value="<?php echo $hasil['nama']; ?>" placeholder="">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Email</h5>
          </td>
          <td>
            <!-- <h5>wawanmtd@gmail.com</h5> -->
            <input type="text" name="email" value="<?php echo $hasil['email']; ?>" placeholder="">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>No.Identitas</h5>
          </td>
          <td>
            <!-- <h5>312874618249</h5> -->
            <input type="text" name="no_identitas" value="<?php echo $hasil['no_identitas']; ?>" placeholder="">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Terdaftar Sebagai</h5>
          </td>
          <td>
            <!-- <h5>Produsen</h5> -->
            <label class="radio ct-azure"><input <?php if ($hasil['level']=="produsen") { echo "checked"; }?> type="radio" name="jenis" data-toggle="radio" id="radio1" value="produsen">Produsen</label>
            <label class="radio ct-azure"><input <?php if ($hasil['level']=="distributor") { echo "checked"; }?> type="radio" name="jenis" data-toggle="radio" id="radio1" value="distributor">Distributor</label>
            <label class="radio ct-azure"><input <?php if ($hasil['level']=="konsumen") { echo "checked"; }?> type="radio" name="jenis" data-toggle="radio" id="radio1" value="konsumen">Konsumen</label>
          </td>
        </tr>
        <tr class="form-horizontal">
          <!-- <td>
            <h5>Tanggal Lahir</h5>
          </td>
          <td>
            <input type="text" name="" value="" placeholder="01/02/12" class="form-control">
          </td> -->
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Alamat</h5>
          </td>
          <td>
            <input type="text" name="alamat" value="<?php echo $hasil['alamat']; ?>" placeholder="JL.benda timur no.4" class="form-control">
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
