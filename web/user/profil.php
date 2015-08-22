<?php 
  $id_user = $_SESSION['user_id'];
  $sql = "SELECT * FROM user WHERE id =$id_user";
  $result = mysql_query($sql)or die(mysql_error());
  $hasil = mysql_fetch_array($result);
 ?>
<div class="container">
  <div class="col-md-4">
  </div>
  <div class="form-group">
  <div class="col-md-4">
    <table>
     <!--  <tr class="form-horizontal text-center">
        <td colspan="4" style="backgroun-color:red;">
          foto
        </td>
      </tr> -->
      <tr class="form-horizontal text-center">
        <td colspan="4">
          <h3><?php echo $hasil['nama']; ?></h3>
        </td>
      </tr>
      <tr class="form-horizontal">
        <td>
          <h5 class="ct-azure">Xp</h5>
        </td>
        <td>
          <h5 class="ct-azure"><?php echo $hasil['xp']; ?></h5>
        </td>
        <td>
          <h5 class="ct-orange">Pts</h5>
        </td>
        <td>
          <h5 class="ct-orange"><?php echo $hasil['poin']; ?></h5>
        </td>
      </tr>
      <tr class="form-horizontal">
        <td colspan="2">
          <h5>Email</h5>
        </td>
        <td colspan="2">
          <h5>: <?php echo $hasil['email']; ?></h5>
        </td>
      </tr>
      <tr class="form-horizontal">
        <td colspan="2">
          <h5>No.Identitas</h5>
        </td>
        <td colspan="2">
          <h5>: <?php echo $hasil['no_identitas']; ?></h5>
        </td>
      </tr>
      <tr class="form-horizontal">
        <td colspan="2">
          <h5>Terdaftar Sebagai</h5>
        </td>
        <td colspan="2">
          <h5>: <?php echo strtoupper($hasil['level']); ?></h5>
        </td>
      </tr>
      <!-- <tr class="form-horizontal">
        <td colspan="2">
          <h5>Tanggal Lahir</h5>
        </td>
        <td colspan="2">
          <h5>: 01/12/12</h5>
        </td>
      </tr> -->
      <tr class="form-horizontal">
        <td colspan="2">
          <h5>Alamat</h5>
        </td>
        <td colspan="2">
          <h5>: <?php echo $hasil['alamat']; ?></h5>
        </td>
      </tr>
      <tr>
        <td colspan="4" class="text-center">
          <a href="?module=edit" class="btn btn-warning">Edit</a>
        </td>
      </tr>
    </table>
  </div>
  </div>
  <div class="col-md-4">

  </div>

</div>
