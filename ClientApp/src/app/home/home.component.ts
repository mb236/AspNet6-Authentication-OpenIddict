import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthorizeService } from 'src/api-authorization/authorize.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  constructor(private route: ActivatedRoute, private authorizatService: AuthorizeService) { }
  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      if(params['logout'] == 1){
        this.authorizatService.signOut({});
      }
    })
  }  
}
