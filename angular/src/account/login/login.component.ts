import { Component, Injector, ElementRef, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { AppComponentBase } from '@shared/app-component-base';
import { LoginService } from './login.service';
import { accountModuleAnimation } from '@shared/animations/routerTransition';
import { AbpSessionService } from '@abp/session/abp-session.service';

import { AuthService } from 'angularx-social-login';
import { FacebookLoginProvider, GoogleLoginProvider, LinkedInLoginProvider } from 'angularx-social-login';

@Component({
    templateUrl: './login.component.html',
    styleUrls: [
        './login.component.less'
    ],
    animations: [accountModuleAnimation()]
})
export class LoginComponent extends AppComponentBase {

    @ViewChild('cardBody') cardBody: ElementRef;

    submitting = false;

    constructor(
        injector: Injector,
        public loginService: LoginService,
        private _router: Router,
        private _sessionService: AbpSessionService,
        private authService: AuthService
    ) {
        super(injector);
    }

    // tslint:disable-next-line:use-life-cycle-interface
    ngAfterViewInit(): void {
        $(this.cardBody.nativeElement).find('input:first').focus();
    }

    get multiTenancySideIsTeanant(): boolean {
        return this._sessionService.tenantId > 0;
    }

    get isSelfRegistrationAllowed(): boolean {
        if (!this._sessionService.tenantId) {
            return false;
        }

        return true;
    }

    login(): void {
        this.submitting = true;
        this.loginService.authenticate(
            () => this.submitting = false
        );
    }

    signInWithGoogle(): void {
        this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
    }

    signInWithFB(): void {
        this.authService.signIn(FacebookLoginProvider.PROVIDER_ID)
            .then(
                (userData)  =>  {
                    // this will return user data from facebook.
                    // What you need is a user token which you will send it to the server
                    this.loginService.sendToRestApiMethod(userData.authToken);
                }
            );
    }

    signInWithLinkedIn(): void {
        this.authService.signIn(LinkedInLoginProvider.PROVIDER_ID);
    }

    signOut(): void {
        this.authService.signOut();
    }
}
