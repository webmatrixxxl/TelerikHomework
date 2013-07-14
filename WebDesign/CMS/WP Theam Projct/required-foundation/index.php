<?php
/**
 * The template for displaying all content.
 *
 * If there aren't any other templates present to
 * display content, it falls back to index.php
 *
 * @package required+ Foundation
 * @since required+ Foundation 0.1.0
 */

get_header(); ?>
<?php get_template_part( 'custom-header' ); ?>
	<!-- Row for main content area -->
	<div id="content" class="row twelve">

		<div id="main" class="six columns" role="main">

			<div class="post-box">

			<?php if ( have_posts() ) : ?>

				<?php while ( have_posts() ) : the_post(); ?>

					<?php get_template_part( 'content', get_post_format() ); ?>

				<?php endwhile; ?>

			<?php else : ?>
				<?php get_template_part( 'content', 'none' ); ?>
			<?php endif; ?>

			<?php if ( function_exists( 'required_pagination' ) ) {
				required_pagination();
			} ?>
			</div>

		</div><!-- /#main -->

		<aside id="sidebar" class="six columns main-page hide-for-medium" role="complementary">

				<?php get_sidebar('Main Sidebar'); ?>
				<?php get_sidebar('Second-Sidebar'); ?>
		</aside>
  <!-- /#sidebar -->

	</div><!-- End Content row -->

<?php get_footer(); ?>