<div class="container">
  <h2 class="text-center">DAFTAR</h2>
    <div class="row">
    <div class="form-group">
      <div class="col-md-4">
      </div>
      <form action="db/singup.php" method="POST" accept-charset="utf-8">
      <table class="col-md-4">
        <tr class="form-horizontal">
          <td>
            <h5>Nama Lengkap</h5>
          </td>
          <td>
            <input type="text" name="nama" value="" placeholder="wawan mtd" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>No.Identitas (ktp/sim)</h5>
          </td>
          <td>
            <input type="text" name="no_identitas" value="" placeholder="123478512" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Email</h5>
          </td>
          <td>
            <input type="email" name="email" value="" placeholder="wawanmtd@gmail.com" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Password</h5>
          </td>
          <td>
            <input type="password" name="pass" value="" placeholder="" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Confirm Password</h5>
          </td>
          <td>
            <input type="password" name="cpass" value="" placeholder="" class="form-control">
          </td>
        </tr>
        <tr class="form-horizontal">
          <td>
            <h5>Daftar Sebagai</h5>
          </td>
          <td>
            <label class="radio ct-azure"><input type="radio" name="jenis" data-toggle="radio" id="radio1" value="produsen">Produsen</label>
            <label class="radio ct-azure"><input type="radio" name="jenis" data-toggle="radio" id="radio1" value="distributor">Distributor</label>
            <label class="radio ct-azure"><input type="radio" name="jenis" data-toggle="radio" id="radio1" value="konsumen">Konsumen</label>
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
