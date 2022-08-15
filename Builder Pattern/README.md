# Builder Pattern
Builder pattern là một trong những Creational pattern. Builder pattern là mẫu thiết kế đối tượng được tạo ra để xây dựng một đôi tượng phức tạp bằng cách sử dụng các đối tượng đơn giản và sử dụng tiếp cận từng bước, việc xây dựng các đối tượng đôc lập với các đối tượng khác

## Implementation
![image](https://user-images.githubusercontent.com/78067510/184677634-978d6a4b-98ad-4ad5-8efa-e921e6a672e7.png)

Một builder gồm các thành phần cơ bản sau:
- Product : đại diện cho đối tượng cần tạo, đối tượng này phức tạp, có nhiều thuộc tính.
- Builder : là abstract class hoặc interface khai báo phương thức tạo đối tượng.
- ConcreteBuilder : kế thừa Builder và cài đặt chi tiết cách tạo ra đối tượng. Nó sẽ xác định và nắm giữ các thể hiện mà nó tạo ra, đồng thời nó cũng cung cấp phương thức để trả các các thể hiện mà nó đã tạo ra trước đó.
- Director/ Client: là nơi sẽ gọi tới Builder để tạo ra đối tượng.

## Benifit
- Giảm bớt số lượng constructor, không cần truyền giá trị null cho các tham số không sử dụng.
- Ít bị lỗi do việc gán sai tham số khi mà có nhiều tham số trong constructor: bởi vì người dùng đã biết được chính xác giá trị gì khi gọi phương thức tương ứng.
- Đối tượng được xây dựng an toàn hơn: bởi vì nó đã được tạo hoàn chỉnh trước khi sử dụng.
- Cung cấp cho bạn kiểm soát tốt hơn quá trình xây dựng: chúng ta có thể thêm xử lý kiểm tra ràng buộc trước khi đối tượng được trả về người dùng.

## Applicability
- Tạo một đối tượng phức tạp: có nhiều thuộc tính (nhiều hơn 4) và một số bắt buộc (requried), một số không bắt buộc (optional).
- Khi có quá nhiều hàm constructor, bạn nên nghĩ đến Builder.
- Muốn tách rời quá trình xây dựng một đối tượng phức tạp từ các phần tạo nên đối tượng.
- Muốn kiểm soát quá trình xây dựng.
- Khi người dùng (client) mong đợi nhiều cách khác nhau cho đối tượng được xây dựng.
