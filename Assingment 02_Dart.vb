import 'dart:io';

class Circle {
  double _radius = 0;
  set radius(double val) {
    _radius = val;
  }

  double get radius => _radius;
  double Calculate_Circumference() {
    double Circumference = 2 * 3.14 * _radius;
    return Circumference;
  }
}

class Student {
  late String Name;
  late int Age;
  late String qualification;
  late double gpa;
  Student(this.Name, this.Age, this.qualification, this.gpa);
  String get Name => Name;
  int get Age => Age;
  String get qualification => qualification;
  double get gpa => gpa;
  set name(String val) {
    _name = val;
  }

  set Age(int val) {
    Age = val;
  }

  set major(String val) {
    qualification = val;
  }

  set gpa(double val) {
    gpa = val;
  }

  String Grade_Level() {
    if (Age >= 18 && Age <= 21) {
      return 'First';
    } else if (Age >= 22 && Age <= 24) {
      return 'mid';
    } else if (Age >= 25 && Age <= 27) {
      return 'Junior';
    } else if (Age >= 28) {
      return 'Senior';
    } else {
      return 'Not Applicable';
    }
  }
}



void main() {
  book b1 = new book();
  b1.setbookprice = 6000;
  b1.setbookTitle = "Machine Learning";
  b1.setbookPublisher = "Oreilly";
  b1.setbookAuthor = "Zohaib Rafiq";
  print("Title of  book is : ${b1.getbookTitle}");
  print("publisher of book is : ${b1.getbookPublisher}");
  print("author of book is: ${b1.getbookAuthor}");
  print("price of book is: ${b1.getbookPrice}");
  double discountedPrice = b1.discountOnBook(25);
  print("after discounted the final price of this book is : $discountedPrice");
}

class book {
  late String title;
  late String author;
  late String publisher;
  late double price;
  set setbookTitle(String title) {
    this.title = title;
  }

  set setbookAuthor(String author) {
    this.author = author;
  }

  set setbookPublisher(String publisher) {
    this.publisher = publisher;
  }

  set setbookprice(double price) {
    this.price = price;
  }

  String get getbookTitle {
    return title;
  }

  String get getbookAuthor {
    return author;
  }

  String get getbookPublisher {
    return publisher;
  }

  double get getbookPrice {
    return price;
  }

  double discountOnBook(double discountinPercentage) {
    double discountedPrice = price - (price * (discountinPercentage / 100));
    return discountedPrice;
  }
}









class Student {



  String Name;
  int Age;
  String qualification;
  double gpa;
  Student(this.Name, this.Age, this.qualification, this.gpa);

  set name(String name) {
    Name = Name;
  }

  get alpha {
    print("Name: ${_name.toUpperCase()} ");
    return Name;
  }

  set age(int age) {
    Age = Age;
  }

  get years {
    print("Age: $my_age");
    return Age;
  }

  set major(String major) {
    qualification = qualification;
  }

  get program {
    print("qualification: ${qualification.toUpperCase()}");
    return qualification;
  }

  set gpa(double gpa) {
    gpa = gpa;
  }

  get grade {
    print("Grade: $gpa");
    return gpa;
  }

  void calculateGrade() {
    if (Age < 10) {
      print("You are in Grade 1-6");
    } else if (Age < 15) {
      print("You are in Grade 6-12");
    } else if (Age < 18) {
      print("You are in Grade 12-18");
    } else {
      print("You are in University");
    }
  }
}
void main() {
  Student student = Student("Zohaib", 23, "BS", 3.35);
  student.alpha;
  student.years;
  student.program;
  student.grade;
  student.calculateGrade();
  student.Name = "Zohaib";
  student.Age = 23;
  student.qualification = "BS";
  student.gpa = 3.35;
  student.alpha;
  student.years;
  student.program;
  student.grade;
  student.calculateGrade();
}



import 'dart:io';

void main() {
  print("Enter A word to check if it is Palindrome or Not: ");
  String wordInput = stdin.readLineSync() as String;
  String word = wordInput;
  if (isPalin(word)) {
    print("The Word is a Palindrome");
  } else {
    print("Word is not a palindrome");
  }
}

bool isPalin(String word) {
  return word == word.split('').reversed.join('');
}

