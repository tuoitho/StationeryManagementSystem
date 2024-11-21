import threading
from concurrent.futures import ThreadPoolExecutor

import pyodbc


# Hàm tạo kết nối đến cơ sở dữ liệu
def create_connection():
    cnxn = pyodbc.connect("Driver={ODBC Driver 17 for SQL Server};"
                          "Server=TuoiTho\SQLEXPRESS;"
                          "Database=StationeryManagementSystem3;"
                          "Trusted_Connection=yes;")
    return cnxn

# Hàm đăng ký ca làm thêm cho từng luồng


def register_shift(employee_id, date):
    cnxn = create_connection()
    cursor = cnxn.cursor()
    try:
        cursor.execute("EXEC sp_DangKiCaLamThem ?, ?", employee_id, date)
        cnxn.commit()
        print(f"Employee {employee_id} đăng ký ca làm thêm thành công.")
    except Exception as e:
        print(f"Employee {employee_id} gặp lỗi.")
    finally:
        cursor.close()
        cnxn.close()

# Hàm thực hiện đa luồng để thử nghiệm


def main():
    # Ngày đăng ký cho tất cả các nhân viên
    date = '2024-11-21'
    # Tạo một ThreadPoolExecutor với số lượng luồng mong muốn
    with ThreadPoolExecutor(max_workers=5) as executor:
        # Tạo danh sách các công việc với ID nhân viên khác nhau
        futures = [
            executor.submit(register_shift, employee_id, date)
            # giả sử nhiều nhân viên đăng ký đồng thời
            for employee_id in [1, 2, 3, 4, 5, 6, 7,8,9,10]
        ]
        # Đợi tất cả các công việc hoàn thành
        for future in futures:
            future.result()


if __name__ == "__main__":
    main()
