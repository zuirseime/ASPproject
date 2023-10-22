import { Component, OnInit } from '@angular/core';
import { User } from 'src/models/user';
import { UserService } from 'src/services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  users : User[] = [];
  title = 'proj';

  constructor(private userService : UserService) {}

  ngOnInit(): void {
    this.userService.getAll().subscribe(data => {
      this.users = data;
    });
    // this.users.push({id : 1, email : "test@gmail.com", password : "1q2w3e4r"});
  }

  onButtonClick() : void {
    let user = new User();
    user.id = 0;
    user.email = "test4@gmail.com";
    user.password = "1234qwer";
    this.userService.add(user).subscribe(data => {
      console.log("User is saved");
    });
  }
}
