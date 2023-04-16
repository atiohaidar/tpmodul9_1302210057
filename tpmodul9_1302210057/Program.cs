   List<Mahasiswa> mahasiswa = new List<Mahasiswa>();
    mahasiswa.Add(new Mahasiswa("Tio Haidar Hanif", "1302210057"));
    mahasiswa.Add(new Mahasiswa("Arya Dul Fitra Ashari", "1302213020"));
    mahasiswa.Add(new Mahasiswa("Muhammad Burhan", "1302213109"));
    mahasiswa.Add(new Mahasiswa("Chandra Bayu Samudra", "1302210134"));
    mahasiswa.Add(new Mahasiswa("Muhammad Irfan Syauqi", "1302210090"));
    mahasiswa.Add(new Mahasiswa("Hasnan Husaini", "1302210100"));

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/mahasiswa", () => {
    return mahasiswa;
}
    );

app.MapGet("api/mahasiswa/{index}", (int index) =>
{
    return mahasiswa[index];
});
app.MapPost("api/mahasiswa", (Mahasiswa mahasiswa_baru) =>
{
    mahasiswa.Add(mahasiswa_baru);
    return "berhasil";
});
app.MapDelete("api/mahasiswa/{index}", (int index) =>
{
     mahasiswa.RemoveAt(index);
    return "berhasil";
});

app.Run();

public class Mahasiswa{
    public string nama { get; set; }
    public string nim { get; set;}
    public Mahasiswa(string nama, string nim)
    {
        this.nama = nama;
        this.nim = nim;

    }
}