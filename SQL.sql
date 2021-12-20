--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: durun(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.durun() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
	update toplamurun set sayi=sayi-1;
return new;
end;
$$;


ALTER FUNCTION public.durun() OWNER TO postgres;

--
-- Name: duye(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.duye() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
	update toplamuye set sayi=sayi-1;
return new;
end;
$$;


ALTER FUNCTION public.duye() OWNER TO postgres;

--
-- Name: iurun(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.iurun() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
	update toplamurun set sayi=sayi+1;
return new;
end;
$$;


ALTER FUNCTION public.iurun() OWNER TO postgres;

--
-- Name: iuye(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.iuye() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
	update toplamuye set sayi=sayi+1;
return new;
end;
$$;


ALTER FUNCTION public.iuye() OWNER TO postgres;

--
-- Name: listelekategori(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.listelekategori() RETURNS TABLE(kategorikodu integer, "kategoriadı" character varying, "urunAdı" character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select kategori_id,kategoriad,urunAd from kategori join kategoriler on kategori.kategoriler_id = kategoriler.kategoriler_id join urunlar on kategori.urun_id = urunlar.urun_id order by kategori_id;
end;
$$;


ALTER FUNCTION public.listelekategori() OWNER TO postgres;

--
-- Name: listelemagaza(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.listelemagaza() RETURNS TABLE(magazakodu integer, "magazaadı" character varying, "urunAdı" character varying, sehir character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select magaza_id,magazaad,urunAd,magazasehir from magaza join magazalar on magaza.magazalar_id = magazalar.magazalar_id join urunlar on magaza.urun_id = urunlar.urun_id order by magaza_id;
end;
$$;


ALTER FUNCTION public.listelemagaza() OWNER TO postgres;

--
-- Name: listeleislemLoglari(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.listeleislemLoglari() RETURNS TABLE(urunkodu integer, "urunAdı" character varying, "Üyeadı" character varying, "Üyesoyadı" character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select islemLoglari_id,urunAd,uyead,uyesoyad from islemLoglari join uyeler on islemLoglari.uye_id = uyeler.uye_id join urunlar on islemLoglari.urun_id = urunlar.urun_id order by islemLoglari_id;
end;
$$;


ALTER FUNCTION public.listeleislemLoglari() OWNER TO postgres;

--
-- Name: listeletur(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.listeletur() RETURNS TABLE(urunkodu integer, "urunAdı" character varying, "urunCesitiadı" character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select tur_id,urunAd,urunCesitiad from tur join urunCesiti on tur.urunCesitiId = urunCesiti.urunCesitiId join urunlar on tur.urun_id = urunlar.urun_id order by tur_id;
end;
$$;


ALTER FUNCTION public.listeletur() OWNER TO postgres;

--
-- Name: listeleseriNo(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.listeleseriNo() RETURNS TABLE(seriNokodu integer, "markaadı" character varying, "urunAdı" character varying)
    LANGUAGE plpgsql
    AS $$
begin
return query
select seriNo_id,markaad,urunAd from seriNo join markalar on seriNo.marka_id = markalar.marka_id join urunlar on seriNo.urun_id = urunlar.urun_id order by seriNo_id;
end;
$$;


ALTER FUNCTION public.listeleseriNo() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: urunCesiti; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urunCesiti (
    urunCesitiId integer NOT NULL,
    urunCesitiad character varying(40) NOT NULL
);


ALTER TABLE public.urunCesiti OWNER TO postgres;

--
-- Name: teshir; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.teshir (
    teshir_id integer NOT NULL,
    teshirad character varying(20) NOT NULL
);


ALTER TABLE public.teshir OWNER TO postgres;

--
-- Name: kategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategori (
    kategori_id integer NOT NULL,
    urun_id integer,
    kategoriler_id integer
);


ALTER TABLE public.kategori OWNER TO postgres;

--
-- Name: kategoriler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kategoriler (
    kategoriler_id integer NOT NULL,
    kategoriad character varying(20) NOT NULL
);


ALTER TABLE public.kategoriler OWNER TO postgres;

--
-- Name: urunlar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urunlar (
    urun_id integer NOT NULL,
    barkod integer NOT NULL,
    urunAd character varying(40) NOT NULL,
    teshir_id integer NOT NULL
);


ALTER TABLE public.urunlar OWNER TO postgres;

--
-- Name: magaza; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.magaza (
    magaza_id integer NOT NULL,
    urun_id integer,
    magazalar_id integer
);


ALTER TABLE public.magaza OWNER TO postgres;

--
-- Name: magazalar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.magazalar (
    magazalar_id integer NOT NULL,
    magazaad character varying(40) NOT NULL,
    magazasehir character varying(20)
);


ALTER TABLE public.magazalar OWNER TO postgres;

--
-- Name: islemLoglari; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.islemLoglari (
    islemLoglari_id integer NOT NULL,
    urun_id integer,
    uye_id integer
);


ALTER TABLE public.islemLoglari OWNER TO postgres;

--
-- Name: toplamurun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.toplamurun (
    sayi integer
);


ALTER TABLE public.toplamurun OWNER TO postgres;

--
-- Name: toplamuye; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.toplamuye (
    sayi integer
);


ALTER TABLE public.toplamuye OWNER TO postgres;


CREATE TABLE public.tur (
    tur_id integer NOT NULL,
    urun_id integer,
    urunCesitiId integer
);


ALTER TABLE public.tur OWNER TO postgres;

--
-- Name: uyeler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.uyeler (
    uye_id integer NOT NULL,
    uyead character varying(20) NOT NULL,
    uyesoyad character varying(20) NOT NULL,
    uyecinsiyet text NOT NULL,
    uyemail text,
    uyetipi_id integer NOT NULL
);


ALTER TABLE public.uyeler OWNER TO postgres;

--
-- Name: uyetipi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.uyetipi (
    uyetipi_id integer NOT NULL,
    uyetipiad character varying(20) NOT NULL
);


ALTER TABLE public.uyetipi OWNER TO postgres;

--
-- Name: viewurunlar; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.viewurunlar AS
 SELECT urunlar.urun_id,
    urunlar.barkod,
    urunlar.urunAd,
    teshir.teshirad
   FROM (public.urunlar
     JOIN public.teshir ON ((urunlar.teshir_id = teshir.teshir_id)))
  ORDER BY urunlar.urun_id;


ALTER TABLE public.viewurunlar OWNER TO postgres;

--
-- Name: viewuyeler; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.viewuyeler AS
 SELECT uyeler.uye_id,
    uyeler.uyead,
    uyeler.uyesoyad,
    uyeler.uyecinsiyet,
    uyeler.uyemail,
    uyetipi.uyetipiad
   FROM (public.uyeler
     JOIN public.uyetipi ON ((uyeler.uyetipi_id = uyetipi.uyetipi_id)))
  ORDER BY uyeler.uye_id;


ALTER TABLE public.viewuyeler OWNER TO postgres;

--
-- Name: seriNo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.seriNo (
    seriNo_id integer NOT NULL,
    urun_id integer,
    marka_id integer
);


ALTER TABLE public.seriNo OWNER TO postgres;

--
-- Name: markalar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.markalar (
    marka_id integer NOT NULL,
    markaad character varying(20) NOT NULL,
    markasehir character varying(20)
);


ALTER TABLE public.markalar OWNER TO postgres;

INSERT INTO public.urunCesiti VALUES
	(1, 'cesit1'),
	(2, 'cesit2'),
	(3, 'cesit4');


--
-- Data for Name: teshir; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.teshir VALUES
	(1, 'Birinci El'),
	(2, 'Teşhir Ürünü');


--
-- Data for Name: kategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kategori VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 2, 3),
	(4, 3, 1),
	(5, 4, 1),
	(6, 4, 2),
	(7, 5, 1),
	(8, 6, 1);


--
-- Data for Name: kategoriler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kategoriler VALUES
	(1, 'Beyaz Esya'),
	(2, 'Küçük Ev Aleti'),
	(3, 'Bilgisayar'),
	(4, 'Monitor'),
	(5, 'Telefon'),
	(6, 'Modem');


--
-- Data for Name: urunlar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.urunlar VALUES
	(1, 1111, 'urun1', 1),
	(2, 2222, 'urun2', 1),
	(3, 3333, 'urun3',  2),
	(4, 4444, 'urun4', 2),
	(5, 5555, 'urun5', 1),
	(6, 6666, 'urun6', 1),
	(7, 7777, 'urun7', 1);


--
-- Data for Name: magaza; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.magaza VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 1),
	(5, 5, 2),
	(6, 6, 3);


--
-- Data for Name: magazalar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.magazalar VALUES
	(1, 'KonyaAltı Avm', 'Antalya'),
	(2, 'Peker Magazaları', 'Samsun'),
	(3, 'GedizOğuları Magazası', 'Edirne');


--
-- Data for Name: islemLoglari; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.islemLoglari VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 1),
	(5, 5, 2),
	(6, 6, 3);


--
-- Data for Name: toplamurun; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.toplamurun VALUES
	(7);


--
-- Data for Name: toplamuye; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.toplamuye VALUES
	(6);


--
-- Data for Name: tur; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tur VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 1),
	(5, 5, 2),
	(6, 6, 3);


--
-- Data for Name: uyeler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.uyeler VALUES
	(1, 'Sinem', 'Ankara', 'Erkek', 'S@mail', 2),
	(2, 'Azra', 'Polatlı', 'Kadın', 'A@mail', 1),
	(3, 'Seyit', 'Balıkesir', 'Kadın', 'S@mail', 2),
	(4, 'Ahmet', 'PASA', 'Erkek', 'A@mail', 2),
	(5, 'Mahmut', 'ZAGNOS', 'Erkek', 'M@mail', 1),
	(6, 'İlknur', 'Selami', 'Kadın', 'I@mail', 1);


--
-- Data for Name: uyetipi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.uyetipi VALUES
	(1, 'Admin'),
	(2, 'Calısan');


--
-- Data for Name: seriNo; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.seriNo VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 1),
	(5, 5, 2),
	(6, 6, 3);


--
-- Data for Name: markalar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.markalar VALUES
	(1, 'Arçelik', 'İstanbul'),
	(2, 'Vestel', 'Manisa'),
	(3, 'BOSCH', 'Berlin');


--
-- Name: urunCesiti serinoPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunCesiti
    ADD CONSTRAINT "serinoPK" PRIMARY KEY (urunCesitiId);


--
-- Name: teshir teshirPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.teshir
    ADD CONSTRAINT "teshirPK" PRIMARY KEY (teshir_id);


--
-- Name: kategori kategoriPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT "kategoriPK" PRIMARY KEY (kategori_id);


--
-- Name: kategoriler kategorilerPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategoriler
    ADD CONSTRAINT "kategorilerPK" PRIMARY KEY (kategoriler_id);


--
-- Name: urunlar urunlarPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunlar
    ADD CONSTRAINT "urunlarPK" PRIMARY KEY (urun_id);


--
-- Name: magaza magazaPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magaza
    ADD CONSTRAINT "magazaPK" PRIMARY KEY (magaza_id);


--
-- Name: magazalar magazalarPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magazalar
    ADD CONSTRAINT "magazalarPK" PRIMARY KEY (magazalar_id);


--
-- Name: islemLoglari islemLoglariPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemLoglari
    ADD CONSTRAINT "islemLoglariPK" PRIMARY KEY (islemLoglari_id);


--
-- Name: tur turPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tur
    ADD CONSTRAINT "turPK" PRIMARY KEY (tur_id);


--
-- Name: uyeler uyelerPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT "uyelerPK" PRIMARY KEY (uye_id);


--
-- Name: uyetipi uyetipiPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyetipi
    ADD CONSTRAINT "uyetipiPK" PRIMARY KEY (uyetipi_id);


--
-- Name: seriNo seriNoPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seriNo
    ADD CONSTRAINT "seriNoPK" PRIMARY KEY (seriNo_id);


--
-- Name: markalar markaPK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.markalar
    ADD CONSTRAINT "markaPK" PRIMARY KEY (marka_id);
--
-- Name: fki_uyelerFK; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_uyelerFK" ON public.uyeler USING btree (uyetipi_id);


--
-- Name: urunlar durunlar; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER durunlar AFTER DELETE ON public.urunlar FOR EACH ROW EXECUTE FUNCTION public.durun();


--
-- Name: uyeler duyeler; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER duyeler AFTER DELETE ON public.uyeler FOR EACH ROW EXECUTE FUNCTION public.duye();


--
-- Name: urunlar iurunlar; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER iurunlar AFTER INSERT ON public.urunlar FOR EACH ROW EXECUTE FUNCTION public.iurun();


--
-- Name: uyeler iuyeler; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER iuyeler AFTER INSERT ON public.uyeler FOR EACH ROW EXECUTE FUNCTION public.iuye();


--
-- Name: kategori kategoriFK1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT "kategoriFK1" FOREIGN KEY (urun_id) REFERENCES public.urunlar(urun_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: kategori kategoriFK2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT "kategoriFK2" FOREIGN KEY (kategoriler_id) REFERENCES public.kategoriler(kategoriler_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: urunlar urunlarFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunlar
    ADD CONSTRAINT "urunlarFK" FOREIGN KEY (teshir_id) REFERENCES public.teshir(teshir_id);


--
-- Name: magaza magazaFK1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magaza
    ADD CONSTRAINT "magazaFK1" FOREIGN KEY (urun_id) REFERENCES public.urunlar(urun_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: magaza magazaFK2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.magaza
    ADD CONSTRAINT "magazaFK2" FOREIGN KEY (magazalar_id) REFERENCES public.magazalar(magazalar_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: islemLoglari islemLoglariFK1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemLoglari
    ADD CONSTRAINT "islemLoglariFK1" FOREIGN KEY (urun_id) REFERENCES public.urunlar(urun_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: islemLoglari islemLoglariFK2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemLoglari
    ADD CONSTRAINT "islemLoglariFK2" FOREIGN KEY (uye_id) REFERENCES public.uyeler(uye_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: tur turFK1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tur
    ADD CONSTRAINT "turFK1" FOREIGN KEY (urun_id) REFERENCES public.urunlar(urun_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: tur turFK2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tur
    ADD CONSTRAINT "turFK2" FOREIGN KEY (urunCesitiId) REFERENCES public.urunCesiti(urunCesitiId) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: uyeler uyelerFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.uyeler
    ADD CONSTRAINT "uyelerFK" FOREIGN KEY (uyetipi_id) REFERENCES public.uyetipi(uyetipi_id) NOT VALID;


--
-- Name: seriNo seriNoFK1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seriNo
    ADD CONSTRAINT "seriNoFK1" FOREIGN KEY (urun_id) REFERENCES public.urunlar(urun_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: seriNo seriNoFK2; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.seriNo
    ADD CONSTRAINT "seriNoFK2" FOREIGN KEY (marka_id) REFERENCES public.markalar(marka_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

