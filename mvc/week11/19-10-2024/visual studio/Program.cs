
// buradaki tüm kodlar aslında main metodun içerisindedir

var builder = WebApplication.CreateBuilder(args);// bir web app olusturucu

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build(); // bir web app(mvc)  olusturuyor
// bu aşamadan run yapılana kadar olan kısımda gelen istekleri yapılandırıyor
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();// htttp uzerinden gelen istekleri htttps e yönlendirir
app.UseStaticFiles();// wwwroot klosörünün kullanabilmesini sağlar 

app.UseRouting(); // gelen isteklerin hangi controller a gitmesi gerektiğini belirler

app.UseAuthorization(); // yetkilendirme özelliklerini aktif kılar

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//https://localhost:5100/Home/Index
//https://localhost:5100/Home   3 ü de aynı yeri acıyor default değer, home action ındex oldugu için
//https://localhost:5100
//https://localhost:5100
//https://localhost:5100
//https://localhost:5100
//https://localhost:5100

app.Run(); // oluşturulan wep app ı çalıştırıyor
