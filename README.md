Cara menggunakan

1. git clone `https://github.com/alvitodev/BudgieVB.git`
2. Buka `BudgieVB.sln`
3. Install `ScottPlot.Winforms` dan `MySql.Data` di Manage NuGet Package for Solutions
4. Import database supaya mudah untuk tes aplikasi
   1. Jalankan server XAMPP dan Apache untuk phpMyAdmin
   2. Import `budgie.sql` yang ada di repo ini
   3. Database siap digunakan
5. Atau buat sendiri database dengan membuat database baru bernama `budgie` lalu jalankan query berikut

   ```sql
   -- 2. Tabel Users
   CREATE TABLE users (
       id INT AUTO_INCREMENT PRIMARY KEY,
       username VARCHAR(50) NOT NULL,
       password_hash VARCHAR(255) NOT NULL, -- Nanti diisi MD5/SHA256
       full_name VARCHAR(100),
       created_at DATETIME DEFAULT CURRENT_TIMESTAMP
   );

   -- 3. Tabel Currencies (5 Mata Uang Konstan)
   CREATE TABLE currencies (
       code VARCHAR(3) PRIMARY KEY, -- IDR, USD, EUR, JPY, GBP
       name VARCHAR(50),
       symbol VARCHAR(5),
       exchange_rate_to_idr DECIMAL(15,2) DEFAULT 1
   );

   -- 4. Tabel Accounts (Dompet/Rekening)
   CREATE TABLE accounts (
       id INT AUTO_INCREMENT PRIMARY KEY,
       user_id INT,
       name VARCHAR(50) NOT NULL,
       currency_code VARCHAR(3),
       balance DECIMAL(15,2) DEFAULT 0,
       color_hex VARCHAR(10) DEFAULT '#000000',
       created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
       FOREIGN KEY (user_id) REFERENCES users(id),
       FOREIGN KEY (currency_code) REFERENCES currencies(code)
   );

   -- 5. Tabel Categories (Global / Per User)
   CREATE TABLE categories (
       id INT AUTO_INCREMENT PRIMARY KEY,
       user_id INT NULL, -- Nullable biar bisa jadi kategori default global
       name VARCHAR(50) NOT NULL,
       type ENUM('Income', 'Expense', 'Transfer') NOT NULL,
       icon_name VARCHAR(50), -- Nama file icon (misal: 'food.png')
       color_hex VARCHAR(10),
       FOREIGN KEY (user_id) REFERENCES users(id)
   );

   -- 6. Tabel Budgets (Anggaran)
   CREATE TABLE budgets (
       id INT AUTO_INCREMENT PRIMARY KEY,
       user_id INT,
       name VARCHAR(100),
       amount_limit DECIMAL(15,2),
       period ENUM('Monthly', 'Weekly', 'Custom'),
       start_date DATE,
       end_date DATE NULL,
       color_hex VARCHAR(10),
       FOREIGN KEY (user_id) REFERENCES users(id)
   );

   -- 7. Tabel Goals (Target)
   CREATE TABLE goals (
       id INT AUTO_INCREMENT PRIMARY KEY,
       user_id INT,
       name VARCHAR(100),
       type ENUM('Income', 'Expense'), -- Income=Nabung, Expense=Bayar Hutang
       target_amount DECIMAL(15,2),
       current_amount DECIMAL(15,2) DEFAULT 0, -- Diupdate otomatis/manual
       target_date DATE NULL,
       color_hex VARCHAR(10),
       FOREIGN KEY (user_id) REFERENCES users(id)
   );

   -- 8. Tabel Transactions (Jantung Aplikasi)
   CREATE TABLE transactions (
       id INT AUTO_INCREMENT PRIMARY KEY,
       user_id INT,
       account_id INT,
       category_id INT,

       budget_id INT NULL, -- Jika masuk budget tertentu
       goal_id INT NULL,   -- Jika masuk goal tertentu

       amount DECIMAL(15,2), -- Negatif = Keluar, Positif = Masuk
       transaction_date DATETIME,
       note TEXT,

       -- Untuk Fitur Transfer (Pairing ID)
       related_transaction_id INT NULL,

       created_at DATETIME DEFAULT CURRENT_TIMESTAMP,

       FOREIGN KEY (user_id) REFERENCES users(id),
       FOREIGN KEY (account_id) REFERENCES accounts(id),
       FOREIGN KEY (category_id) REFERENCES categories(id),
       FOREIGN KEY (budget_id) REFERENCES budgets(id),
       FOREIGN KEY (goal_id) REFERENCES goals(id)
   );

   -- ==============================================
   -- SEEDING DATA (Data Awal Biar Gak Kosong)
   -- ==============================================

   -- A. Isi Mata Uang
   INSERT INTO currencies (code, name, symbol, exchange_rate_to_idr) VALUES
   ('IDR', 'Indonesian Rupiah', 'Rp', 1),
   ('USD', 'US Dollar', '$', 15500),
   ('EUR', 'Euro', '€', 16500),
   ('JPY', 'Japanese Yen', '¥', 105),
   ('GBP', 'British Pound', '£', 19500);

   -- B. Isi Kategori Default (Ikon nanti disesuaikan)
   INSERT INTO categories (name, type, color_hex) VALUES
   ('Makan & Minum', 'Expense', '#FF5733'),
   ('Transportasi', 'Expense', '#33FF57'),
   ('Belanja', 'Expense', '#3357FF'),
   ('Tagihan', 'Expense', '#FF33A1'),
   ('Gaji', 'Income', '#33FFF5'),
   ('Hadiah', 'Income', '#F5FF33'),
   ('Transfer', 'Transfer', '#888888');

   -- C. Buat 1 User Dummy (ID = 1) -> Supaya bisa langsung login/test tanpa register
   INSERT INTO users (id, username, password_hash, full_name) VALUES
   (1, 'alvito', '123', 'Muhammad Alvito');
   -- Password masih plain '123' karena belum ada enkripsi di kodingan login sementara

   -- D. Buat 1 Akun Default untuk User ID 1
   INSERT INTO accounts (user_id, name, currency_code, balance, color_hex) VALUES
   (1, 'Dompet Tunai', 'IDR', 0, '#2ECC71'),
   (1, 'Bank BCA', 'IDR', 0, '#3498DB');
   ```

6. Jalankan aplikasi dengan tekan `F5` atau klik tombol Play
